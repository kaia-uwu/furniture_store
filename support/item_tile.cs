using System.Drawing;
using System.Windows.Forms;

using furniture_store.pages;
using furniture_store.database_types;

using MySql.Data.MySqlClient;

namespace furniture_store.support
{
    public partial class item_tile : UserControl
    {
        private main_form main_form;
        private dashboard_page dashboard_page;
        private build build;
        public item_tile(main_form p_main_form, build p_build)
        {
            main_form = p_main_form;
            dashboard_page = (dashboard_page)main_form.get_page("dashboard");
            build = p_build;

            InitializeComponent();

            name_label.Text = build.item.name;
            decimal price = build.item.price;

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

        private void clicked(object sender, System.EventArgs e)
        {
            main_form.set_page(new item_page(main_form, build));
        }

        private void add_to_cart_clicked(object sender, System.EventArgs e)
        {
            if (dashboard_page.user == null)
                return;

            MySqlConnection db_connection = main_form.db_connection;

            new MySqlCommand($"call add_to_cart({dashboard_page.user.id}, {build.id}, 1);", db_connection).ExecuteNonQuery();
        }
    }
}
