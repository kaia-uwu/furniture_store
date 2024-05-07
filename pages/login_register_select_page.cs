using System;
using System.Windows.Forms;

namespace furniture_store.pages
{
    public partial class login_register_select_page : UserControl
    {
        private main_form main_form;
        public login_register_select_page(main_form p_main_form)
        {
            main_form = p_main_form;
            Dock = DockStyle.Fill;

            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            main_form.set_page("login");
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            main_form.set_page("register");
        }
    }
}
