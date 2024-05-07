using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace furniture_store.pages
{
    public partial class register_page : UserControl
    {
        private main_form main_form;
        public register_page(main_form p_main_form)
        {
            main_form = p_main_form;
            Dock = DockStyle.Fill;

            InitializeComponent();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            string username = username_textbox.Text;

            string first_name = first_name_textbox.Text;
            string last_name = last_name_textbox.Text;
            string phone_number = phone_number_textbox.Text;

            string password = password_textbox.Text;
            string repeat_password = password_repeat_textbox.Text;
            if (password != repeat_password)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MySqlConnection db_connection = main_form.db_connection;

            bool is_taken = true;

            using (MySqlDataReader reader = new MySqlCommand($"select count(id) from users where username = '{username}'", db_connection).ExecuteReader())
                if (reader.Read())
                    if (reader.GetUInt32(0) == 0)
                        is_taken = false;

            if (is_taken)
            {
                MessageBox.Show("Username is already taken!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            new MySqlCommand(
                $"call add_user('{username}', '{password}', '{first_name}', '{last_name}', '{phone_number}')",
                db_connection).ExecuteNonQuery();

            MessageBox.Show("User created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            main_form.set_page("login_register_select");
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            username_textbox.Text = "";
            first_name_textbox.Text = "";
            last_name_textbox.Text = "";
            phone_number_textbox.Text = "";
            password_textbox.Text = "";
            password_repeat_textbox.Text = "";

            main_form.set_page("login_register_select");
        }

        private void textbox_text_changed(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            textbox.Text = textbox.Text.Trim();
        }
    }
}
