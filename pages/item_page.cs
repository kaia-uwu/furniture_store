using System;
using System.Windows.Forms;

using furniture_store.support;
using furniture_store.resources;
using furniture_store.database_types;

using min3d_Forms_Edition_Multipanel_Library;

using MySql.Data.MySqlClient;

namespace furniture_store.pages
{
    public partial class item_page : UserControl
    {
        private main_form main_form;
        private dashboard_page dashboard_page;
        private build build;
        private item_resource_set? item_resource_set;
        public item_page(main_form p_main_form, build p_build)
        {
            main_form = p_main_form;
            dashboard_page = (dashboard_page)main_form.get_page("dashboard");
            build = p_build;

            item item = build.item;
            if (main_form.items.ContainsKey(item.name))
                item_resource_set = main_form.items[item.name];

            Dock = DockStyle.Fill;

            InitializeComponent();
        }

        private void profile_button_click(object sender, EventArgs e)
        {
            unload();

            main_form.set_page("profile");
        }
        private void cart_button_click(object sender, EventArgs e)
        {
            unload();

            main_form.set_page("cart");
        }
        private void back_button_click(object sender, EventArgs e)
        {
            unload();

            main_form.set_page("dashboard");
        }

        private void add_to_cart(object sender, EventArgs e)
        {
            if (dashboard_page.user == null)
                return;

            MySqlConnection db_connection = main_form.db_connection;

            if (build.id == 0)
            {
                #region build command

                string command =
                        $"start transaction;\n" +
                        $"  call add_build({build.item.id}, false);\n" +
                        $"  set @build_id = LAST_INSERT_ID();\n";

                foreach (build_part build_part in build.parts)
                {
                    command +=
                        $"  call add_build_part(@build_id, {build_part.part.id}, {build_part.material.id});\n";
                }

                command +=
                    $"  call add_to_cart({dashboard_page.user.id}, @build_id, 1);\n" +
                    $"commit;";

                #endregion

                new MySqlCommand(command, db_connection).ExecuteNonQuery();

                dashboard_page.load_builds();
                build = dashboard_page.try_swap_for_existing(build);
            }
            else
                new MySqlCommand($"call add_to_cart({dashboard_page.user.id}, {build.id}, 1);", db_connection).ExecuteNonQuery();
        }

        unsafe private void load(object sender, EventArgs e)
        {
            item item = build.item;

            name_label.Text = item.name;

            if (item_resource_set == null)
                return;

            #region selected

            decimal price = item.price;

            foreach (build_part build_part in build.parts)
            {
                price += build_part.material.added_price;

                if (!item_resource_set.parts.ContainsKey(build_part.part.name))
                    continue;

                part_material_select part_material_select = new part_material_select(main_form, this, build_part);
                parts_flow_layout_panel.Controls.Add(part_material_select);
            }

            price_label.Text = price.ToString();

            #endregion

            renderer renderer = main_form.renderer;

            #region viewport_1
            {
                render_instance instance = new render_instance(renderer, viewport_1);
                viewport_1.instance = instance;

                if (!item_resource_set.configurations.ContainsKey("spinning"))
                    return;
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

                    textured_mesh mesh = new textured_mesh(part_resource_set.mesh, main_form.textures[build_part.material.name]);
                    mesh.tri_program = part_resource_set.tri_program;

                    instance.meshes.Add(mesh);
                }

                renderer.instances.Add(instance);
                viewport_1.start();
            }
            #endregion

            #region viewport_2
            {
                render_instance instance = new render_instance(renderer, viewport_2);
                viewport_2.instance = instance;

                if (!item_resource_set.configurations.ContainsKey("top"))
                    return;
                render_configuration top = item_resource_set.configurations["top"];

                instance.cam_pos = top.cam_pos;
                instance.cam_fwd = top.cam_fwd;
                instance.cam_up = top.cam_up;
                instance.cam_right = top.cam_right;

                instance.light_direction = top.light_direction;

                instance.fov = top.fov;

                foreach (build_part build_part in build.parts)
                {
                    if (!item_resource_set.parts.ContainsKey(build_part.part.name))
                        continue;

                    part_resource_set part_resource_set = item_resource_set.parts[build_part.part.name];

                    textured_mesh mesh = new textured_mesh(part_resource_set.mesh, main_form.textures[build_part.material.name]);
                    mesh.tri_program = part_resource_set.tri_program;

                    instance.meshes.Add(mesh);
                }

                renderer.instances.Add(instance);
                viewport_2.start();
            }
            #endregion

            #region viewport_3
            {
                render_instance instance = new render_instance(renderer, viewport_3);
                viewport_3.instance = instance;

                if (!item_resource_set.configurations.ContainsKey("front"))
                    return;
                render_configuration front = item_resource_set.configurations["front"];

                instance.cam_pos = front.cam_pos;
                instance.cam_fwd = front.cam_fwd;
                instance.cam_up = front.cam_up;
                instance.cam_right = front.cam_right;

                instance.light_direction = front.light_direction;

                instance.fov = front.fov;

                foreach (build_part build_part in build.parts)
                {
                    if (!item_resource_set.parts.ContainsKey(build_part.part.name))
                        continue;

                    part_resource_set part_resource_set = item_resource_set.parts[build_part.part.name];

                    textured_mesh mesh = new textured_mesh(part_resource_set.mesh, main_form.textures[build_part.material.name]);
                    mesh.tri_program = part_resource_set.tri_program;

                    instance.meshes.Add(mesh);
                }

                renderer.instances.Add(instance);
                viewport_3.start();
            }
            #endregion

            #region viewport_4
            {
                render_instance instance = new render_instance(renderer, viewport_4);
                viewport_4.instance = instance;

                if (!item_resource_set.configurations.ContainsKey("side"))
                    return;
                render_configuration side = item_resource_set.configurations["side"];

                instance.cam_pos = side.cam_pos;
                instance.cam_fwd = side.cam_fwd;
                instance.cam_up = side.cam_up;
                instance.cam_right = side.cam_right;

                instance.light_direction = side.light_direction;

                instance.fov = side.fov;

                foreach (build_part build_part in build.parts)
                {
                    if (!item_resource_set.parts.ContainsKey(build_part.part.name))
                        continue;

                    part_resource_set part_resource_set = item_resource_set.parts[build_part.part.name];

                    textured_mesh mesh = new textured_mesh(part_resource_set.mesh, main_form.textures[build_part.material.name]);
                    mesh.tri_program = part_resource_set.tri_program;

                    instance.meshes.Add(mesh);
                }

                renderer.instances.Add(instance);
                viewport_4.start();
            }
            #endregion

            renderer.start();
        }
        private void unload()
        {
            renderer renderer = main_form.renderer;

            renderer.stop();

            foreach (render_instance instance in renderer.instances)
                instance.Dispose();
            renderer.instances.Clear();

            Dispose();

            GC.Collect();
        }
        unsafe private void reload()
        {
            decimal price = build.item.price;
            foreach (build_part build_part in build.parts)
                price += build_part.material.added_price;
            price_label.Text = price.ToString();

            if (item_resource_set == null)
                return;

            renderer renderer = main_form.renderer;

            renderer.stop();

            #region viewport_1
            {
                viewport_1.stop();

                render_instance instance = viewport_1.instance;

                instance.meshes.Clear();
                foreach (build_part build_part in build.parts)
                {
                    if (!item_resource_set.parts.ContainsKey(build_part.part.name))
                        continue;

                    part_resource_set part_resource_set = item_resource_set.parts[build_part.part.name];

                    textured_mesh mesh = new textured_mesh(part_resource_set.mesh, main_form.textures[build_part.material.name]);
                    mesh.tri_program = part_resource_set.tri_program;

                    instance.meshes.Add(mesh);
                }

                viewport_1.start();
            }
            #endregion

            #region viewport_2
            {
                viewport_2.stop();

                render_instance instance = viewport_2.instance;

                instance.meshes.Clear();
                foreach (build_part build_part in build.parts)
                {
                    if (!item_resource_set.parts.ContainsKey(build_part.part.name))
                        continue;

                    part_resource_set part_resource_set = item_resource_set.parts[build_part.part.name];

                    textured_mesh mesh = new textured_mesh(part_resource_set.mesh, main_form.textures[build_part.material.name]);
                    mesh.tri_program = part_resource_set.tri_program;

                    instance.meshes.Add(mesh);
                }

                viewport_2.start();
            }
            #endregion

            #region viewport_3
            {
                viewport_3.stop();

                render_instance instance = viewport_3.instance;

                instance.meshes.Clear();
                foreach (build_part build_part in build.parts)
                {
                    if (!item_resource_set.parts.ContainsKey(build_part.part.name))
                        continue;

                    part_resource_set part_resource_set = item_resource_set.parts[build_part.part.name];

                    textured_mesh mesh = new textured_mesh(part_resource_set.mesh, main_form.textures[build_part.material.name]);
                    mesh.tri_program = part_resource_set.tri_program;

                    instance.meshes.Add(mesh);
                }

                viewport_3.start();
            }
            #endregion

            #region viewport_4
            {
                viewport_4.stop();

                render_instance instance = viewport_4.instance;

                instance.meshes.Clear();
                foreach (build_part build_part in build.parts)
                {
                    if (!item_resource_set.parts.ContainsKey(build_part.part.name))
                        continue;

                    part_resource_set part_resource_set = item_resource_set.parts[build_part.part.name];

                    textured_mesh mesh = new textured_mesh(part_resource_set.mesh, main_form.textures[build_part.material.name]);
                    mesh.tri_program = part_resource_set.tri_program;

                    instance.meshes.Add(mesh);
                }

                viewport_4.start();
            }
            #endregion

            renderer.start();
        }

        public void alter_build_part_material(build_part p_build_part)
        {
            build = dashboard_page.try_get_existing_build_or_create_copy(build, p_build_part);

            reload();
        }
    }
}
