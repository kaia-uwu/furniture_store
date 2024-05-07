using System.Drawing;
using System.Windows.Forms;

using furniture_store.pages;
using furniture_store.database_types;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace furniture_store.support
{
    public partial class cart_build_tile : UserControl
    {
        private main_form main_form;
        private dashboard_page dashboard_page;
        private cart_page cart_page;
        private build build;
        public uint quantity;
        public decimal price;
        public cart_build_tile(main_form p_main_form, build p_build, uint p_quantity)
        {
            main_form = p_main_form;
            dashboard_page = (dashboard_page)main_form.get_page("dashboard");
            cart_page = (cart_page)main_form.get_page("cart");
            build = p_build;
            quantity = p_quantity;

            InitializeComponent();

            quantity_textbox.Text = quantity.ToString();
            quantity_textbox.TextChanged += new System.EventHandler(quantity_changed);

            name_label.Text = build.item.name;
            price = build.item.price;

            foreach (build_part build_part in build.parts)
            {
                price += build_part.material.added_price;

                material material = build_part.material;

                if (!main_form.material_icons.ContainsKey(material.name))
                    continue;

                PictureBox material_preview_picture_box = new PictureBox();

                material_preview_picture_box.Image = main_form.material_icons[material.name];
                material_preview_picture_box.Size = new Size(30, 30);
                material_preview_picture_box.BackColor = Color.White;

                materials_flow_layout_panel.Controls.Add(material_preview_picture_box);
            }

            price_label.Text = price.ToString();
        }

        private void quantity_changed(object? sender, System.EventArgs e)
        {
            uint new_quantity;
            if (sender != null && sender == remove_button)
            {
                new_quantity = 0;
            }
            else if (!uint.TryParse(quantity_textbox.Text, out new_quantity))
                return;

            #region command

            user? user = dashboard_page.user;
            if (user == null)
                return;

            MySqlConnection db_connection = main_form.db_connection;

            new MySqlCommand($"call edit_in_cart({user.id}, {build.id}, {new_quantity});", db_connection).ExecuteNonQuery();

            #endregion

            quantity = new_quantity;

            cart_page.calculate_price();
        }
    }
}
