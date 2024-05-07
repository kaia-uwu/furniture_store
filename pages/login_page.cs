using System;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

using furniture_store.database_types;

namespace furniture_store.pages
{
    public partial class login_page : UserControl
    {
        private main_form main_form;
        public login_page(main_form p_main_form)
        {
            main_form = p_main_form;
            Dock = DockStyle.Fill;

            InitializeComponent();
        }

        private void login_button_click(object sender, EventArgs e)
        {
            #region get user

            string username = username_textbox.Text;
            string password = password_textbox.Text;

            MySqlConnection db_connection = main_form.db_connection;

            user? user = null;

            using (MySqlCommand command = new MySqlCommand($"select id, first_name, last_name, phone_number from users where username = '{username}' and _password = '{password}' limit 1;", db_connection))
            using (MySqlDataReader reader = command.ExecuteReader())
                if (reader.Read())
                {
                    string? first_name = null;
                    if (!reader.IsDBNull(1))
                        first_name = reader.GetString(1);

                    string? last_name = null;
                    if (!reader.IsDBNull(2))
                        last_name = reader.GetString(2);

                    string? phone_number = null;
                    if (!reader.IsDBNull(3))
                        phone_number = reader.GetString(3);

                    user = new user(username, password, first_name, last_name, phone_number, reader.GetUInt32(0));
                }
                    

            #endregion

            if (user != null)
            {
                ((dashboard_page)main_form.get_page("dashboard")).user = user;

                username_textbox.Text = "";
                password_textbox.Text = "";

                main_form.set_page("dashboard");
            }
            else
                MessageBox.Show("Incorrect username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void back_button_click(object sender, EventArgs e)
        {
            username_textbox.Text = "";
            password_textbox.Text = "";

            main_form.set_page("login_register_select");
        }

        private void textbox_text_changed(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            textbox.Text = textbox.Text.Trim();
        }
    }
}
