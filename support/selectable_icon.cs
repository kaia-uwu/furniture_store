using System;
using System.Drawing;
using System.Windows.Forms;

using furniture_store.database_types;

namespace furniture_store.support
{
    public partial class selectable_icon : UserControl
    {
        private main_form main_form;
        private part_material_select part_material_select;

        public readonly part part;
        public readonly material material;

        private bool selected;
        public selectable_icon(main_form p_main_form, part_material_select p_part_material_select, part p_part, material p_material, bool p_selected = false)
        {
            main_form = p_main_form;
            part_material_select = p_part_material_select;

            part = p_part;
            material = p_material;
            selected = p_selected;

            InitializeComponent();

            if (!main_form.material_icons.ContainsKey(material.name))
                return;
            picture_box.Image = main_form.material_icons[material.name];

            selected_changed(false);
        }
        public void selected_changed(bool p_escalate = true)
        {
            if (selected)
            {
                if (p_escalate)
                    part_material_select.change_select(this);
                BackColor = Color.MistyRose;
            }
            else
                BackColor = Color.Transparent;
        }
        private void select(object sender, EventArgs e)
        {
            if (selected)
                return;

            selected = true;

            selected_changed();
        }
        public void unselect()
        {
            selected = false;

            selected_changed(false);
        }
    }
}
