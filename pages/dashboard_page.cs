using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

using MySql.Data.MySqlClient;

using furniture_store.support;
using furniture_store.resources;
using furniture_store.database_types;

using min3d_Forms_Edition_Multipanel_Library;

namespace furniture_store.pages
{
    public partial class dashboard_page : UserControl
    {
        private main_form main_form;

        public List<item> items;
        public List<build> builds;

        public user? user;
        public dashboard_page(main_form p_main_form)
        {
            items = new List<item>();
            builds = new List<build>();

            main_form = p_main_form;
            Dock = DockStyle.Fill;

            InitializeComponent();
        }

        private void logout_button_click(object sender, EventArgs e)
        {
            main_form.set_page("login_register_select");
        }
        private void cart_button_click(object sender, EventArgs e)
        {
            main_form.set_page("cart");
        }

        private void load(object sender, EventArgs e)
        {
            load();
        }
        private void visible_changed(object sender, EventArgs e)
        {
            if (Visible)
            {
                load();
            }
            else
            {
                unload();
            }
        }

        private void unload()
        {
            renderer renderer = main_form.renderer;

            renderer.stop();

            foreach (render_instance instance in renderer.instances)
                instance.Dispose();
            renderer.instances.Clear();

            foreach (item_tile tile in items_flow_layout_panel.Controls.OfType<item_tile>())
                tile.Dispose();
            items_flow_layout_panel.Controls.Clear();

            GC.Collect();
        }
        unsafe private void load()
        {
            if (user == null)
                return;

            #region welcome text

            if (user.first_name != null || user.last_name != null)
            {
                string welcome_text = "Welcome, ";

                if (user.first_name != null)
                    welcome_text += user.first_name + " ";

                if (user.last_name != null)
                    welcome_text += user.last_name;

                welcome_label.Text = welcome_text;
            }

            #endregion

            #region get all items, parts and materials

            MySqlConnection db_connection = main_form.db_connection;

            items.Clear();
            using (MySqlCommand command = new MySqlCommand("select * from all_items;", db_connection))
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    item current_item;

                    uint item_id = reader.GetUInt32(0);
                    item? swap_item = items.Find(x => x.id == item_id);
                    if (swap_item == null)
                    {
                        current_item = new item(reader.GetString(1), reader.GetDecimal(2), item_id);
                        items.Add(current_item);
                    }
                    else
                        current_item = swap_item;

                    part current_part;

                    uint part_id = reader.GetUInt32(3);
                    part? swap_part = current_item.parts.Find(x => x.id == part_id);
                    if (swap_part == null)
                    {
                        current_part = new part(reader.GetString(4), part_id);
                        current_item.parts.Add(current_part);
                    }
                    else
                        current_part = swap_part;

                    current_part.materials.Add(new material(reader.GetString(6), reader.GetDecimal(7), reader.GetUInt32(5)));
                }
            }

            load_builds();

            #endregion

            #region create and launch tiles

            renderer renderer = main_form.renderer;

            foreach (build build in builds.Where(x => x.is_default))
            {
                item item = build.item;

                if (!main_form.items.ContainsKey(item.name))
                    continue;

                item_resource_set item_resource_set = main_form.items[item.name];

                item_tile tile = new item_tile(main_form, build);
                render_instance instance = new render_instance(renderer, tile.viewport);
                tile.viewport.instance = instance;

                render_configuration spinning = item_resource_set.configurations["spinning"];

                instance.cam_pos = spinning.cam_pos;
                instance.cam_fwd = spinning.cam_fwd;
                instance.cam_up = spinning.cam_up;
                instance.cam_right = spinning.cam_right;

                instance.light_direction = spinning.light_direction;

                instance.fov = spinning.fov;

                instance.alloc_program_buffer(spinning.buffer_size);

                instance.frame_program = spinning.frame_program;
                instance.tri_program = spinning.tri_program;

                foreach (build_part build_part in build.parts)
                {
                    if (!item_resource_set.parts.ContainsKey(build_part.part.name))
                        continue;

                    part_resource_set part_resource_set = item_resource_set.parts[build_part.part.name];

                    if (!main_form.textures.ContainsKey(build_part.material.name))
                        return;

                    textured_mesh mesh = new textured_mesh(part_resource_set.mesh, main_form.textures[build_part.material.name]);
                    mesh.tri_program = part_resource_set.tri_program;

                    instance.meshes.Add(mesh);
                }

                renderer.instances.Add(instance);
                tile.viewport.start();
                items_flow_layout_panel.Controls.Add(tile);
            }

            renderer.start();

            #endregion
        }
        unsafe public void load_builds()
        {
            if (user == null)
                return;

            MySqlConnection db_connection = main_form.db_connection;

            builds.Clear();
            using (MySqlCommand command = new MySqlCommand($"select * from all_default_builds;", db_connection))
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    build current_build;

                    uint build_id = reader.GetUInt32(0);
                    build? swap_build = builds.Find(x => x.id == build_id);
                    if (swap_build == null)
                    {
                        string item_name = reader.GetString(1);
                        item? item = items.Find(x => x.name == item_name);
                        if (item == null)
                            continue;

                        current_build = new build(item, true, reader.GetUInt32(0));
                        builds.Add(current_build);
                    }
                    else
                        current_build = swap_build;

                    string part_name = reader.GetString(2);
                    part? part = current_build.item.parts.Find(x => x.name == part_name);
                    if (part == null)
                        continue;

                    string material_name = reader.GetString(3);
                    material? material = part.materials.Find(x => x.name == material_name);
                    if (material == null)
                        continue;

                    current_build.parts.Add(new build_part(part, material));
                }
            }

            using (MySqlCommand command = new MySqlCommand($"select * from all_non_default_user_cart_builds where user_id = {user.id};", db_connection))
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    build current_build;

                    uint build_id = reader.GetUInt32(1);
                    build? swap_build = builds.Find(x => x.id == build_id);
                    if (swap_build == null)
                    {
                        string item_name = reader.GetString(2);
                        item? item = items.Find(x => x.name == item_name);
                        if (item == null)
                            continue;

                        current_build = new build(item, false, build_id);
                        builds.Add(current_build);
                    }
                    else
                        current_build = swap_build;

                    string part_name = reader.GetString(3);
                    part? part = current_build.item.parts.Find(x => x.name == part_name);
                    if (part == null)
                        continue;

                    string material_name = reader.GetString(4);
                    material? material = part.materials.Find(x => x.name == material_name);
                    if (material == null)
                        continue;

                    current_build.parts.Add(new build_part(part, material));
                }
            }
        }

        public build try_swap_for_existing(build p_build)
        {
            build? existing_build = builds.Find(x => x.compare_similar(p_build));
            if (existing_build != null)
                return existing_build;

            return p_build;
        }
        public build try_get_existing_build_or_create_copy(build p_build, build_part p_altered_build_part)
        {
            build build_copy = new build(p_build, p_altered_build_part);

            build? existing_build = builds.Find(x => x.compare_similar(build_copy));
            if (existing_build != null)
                return existing_build;

            return build_copy;
        }
    }
}
