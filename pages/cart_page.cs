using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

using furniture_store.support;
using furniture_store.database_types;

using MySql.Data.MySqlClient;

namespace furniture_store.pages
{
    public partial class cart_page : UserControl
    {
        private main_form main_form;
        private dashboard_page dashboard_page;
        public cart_page(main_form p_main_form)
        {
            main_form = p_main_form;
            Dock = DockStyle.Fill;

            dashboard_page = (dashboard_page)main_form.get_page("dashboard");

            InitializeComponent();
        }

        private void back_button_click(object sender, System.EventArgs e)
        {
            main_form.set_page("dashboard");
        }

        private void load(object sender, System.EventArgs e)
        {
            load();
        }
        private void visible_changed(object sender, System.EventArgs e)
        {
            if (Visible)
                load();
        }

        private void load()
        {
            user? user = dashboard_page.user;
            if (user == null)
                return;

            MySqlConnection db_connection = main_form.db_connection;

            

            foreach (cart_build_tile cart_build_tile in cart_build_flow_layout_panel.Controls.OfType<cart_build_tile>())
                cart_build_tile.Dispose();
            cart_build_flow_layout_panel.Controls.Clear();

            List<Tuple<build, uint>> builds_with_quantities = new List<Tuple<build, uint>>();

            using (MySqlCommand command = new MySqlCommand($"select build_id, quantity from cart where user_id = {user.id};", db_connection))
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    build? build = dashboard_page.builds.Find(x => x.id == reader.GetUInt32(0));
                    if (build == null)
                        continue;

                    builds_with_quantities.Add(new Tuple<build, uint>(build, reader.GetUInt32(1)));
                }
            }

            foreach (Tuple<build, uint> build_with_quantity in builds_with_quantities)
            {
                cart_build_tile cart_build_tile = new cart_build_tile(main_form, build_with_quantity.Item1, build_with_quantity.Item2);
                cart_build_flow_layout_panel.Controls.Add(cart_build_tile);
            }

            calculate_price();
        }
        public void calculate_price()
        {
            decimal total = 0;

            foreach (cart_build_tile cart_build_tile in cart_build_flow_layout_panel.Controls.OfType<cart_build_tile>())
            {
                if (cart_build_tile.quantity == 0)
                {
                    cart_build_tile.Dispose();
                    cart_build_flow_layout_panel.Controls.Remove(cart_build_tile);
                } 

                total += cart_build_tile.price * cart_build_tile.quantity;
            }

            total_label.Text = total.ToString();
        }

        private void place_order(object sender, System.EventArgs e)
        {
            user? user = dashboard_page.user;
            if (user == null)
                return;

            MySqlConnection db_connection = main_form.db_connection;

            MySqlCommand command = new MySqlCommand($"call create_order_from_cart({user.id}, o_order_id);", db_connection);

            command.Parameters.Add("o_order_id", MySqlDbType.UInt32);
            command.Parameters["o_order_id"].Direction = System.Data.ParameterDirection.Output;

            command.ExecuteNonQuery();

            uint? order_id = (uint?)command.Parameters["o_order_id"].Value;
            if (order_id == null)
            {
                MessageBox.Show("Failed to create order!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Order created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            load();
        }
    }
}
