using System.Linq;
using System.Windows.Forms;

using furniture_store.pages;
using furniture_store.database_types;

namespace furniture_store.support
{
    public partial class part_material_select : UserControl
    {
        private main_form main_form;
        private item_page item_page;

        private build_part build_part;
        private material selected_material;
        public part_material_select(main_form p_main_form, item_page p_item_page, build_part p_build_part)
        {
            main_form = p_main_form;
            item_page = p_item_page;

            build_part = p_build_part;
            selected_material = build_part.material;

            InitializeComponent();

            name_label.Text = build_part.part.name;

            foreach (material material in build_part.part.materials)
            {
                if (!main_form.material_icons.ContainsKey(material.name))
                    continue;

                bool selected = false;
                if (material == build_part.material)
                {
                    selected_material = material;
                    selected = true;
                }

                materials_flow_layout_panel.Controls.Add(new selectable_icon(main_form, this, build_part.part, material, selected));
            }
        }

        public void change_select(selectable_icon p_selectable_icon)
        {
            foreach (selectable_icon selectable_icon in materials_flow_layout_panel.Controls.OfType<selectable_icon>())
                if (selectable_icon != p_selectable_icon)
                    selectable_icon.unselect();

            selected_material = p_selectable_icon.material;

            item_page.alter_build_part_material(new build_part(build_part.part, selected_material));
        }
    }
}
