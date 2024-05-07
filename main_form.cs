using System;
using System.Numerics;
using System.Windows.Forms;
using System.Collections.Generic;

using MySql.Data.MySqlClient;

using furniture_store.pages;
using furniture_store.resources;

using min3d_Forms_Edition_Multipanel_Library;
using System.Drawing;

namespace furniture_store
{
    public partial class main_form : Form
    {
        public renderer renderer;

        public Dictionary<string, Bitmap> material_icons;
        public Dictionary<string, item_resource_set> items;
        public Dictionary<string, texture> textures;

        public MySqlConnection db_connection;

        private Dictionary<string, UserControl> pages;
        private UserControl? current_page;
        public main_form()
        {
            items = new Dictionary<string, item_resource_set>();
            material_icons = new Dictionary<string, Bitmap>();
            textures = new Dictionary<string, texture>();

            #region renderer, models and textures
            renderer = new renderer();

            load_renderer_assets();
            #endregion

            #region db connection

            db_connection = new MySqlConnection("server = localhost; uid = root; pwd = mysqlsucks; database = furniture_store; allow user variables = true;"); // Pakistan123/mysqlsucks
            db_connection.Open();

            #endregion

            #region pages
            pages = new Dictionary<string, UserControl>();

            add_page("login_register_select", new login_register_select_page(this));
            add_page("login", new login_page(this));
            add_page("register", new register_page(this));
            add_page("dashboard", new dashboard_page(this));
            add_page("cart", new cart_page(this));

            set_page("login_register_select");
            #endregion

            InitializeComponent();
        }

        unsafe public void load_renderer_assets()
        {
            #region models

            #region support functions
            void create_rect(ref tri[] p_mesh, int p_index, Vector3 p_a, Vector3 p_b, Vector3 p_c, Vector3 p_d)
            {
                p_mesh[p_index] =
                    new tri()
                    {
                        v0 = new Vector4(p_a, 1),
                        v1 = new Vector4(p_b, 1),
                        v2 = new Vector4(p_c, 1),
                        t0 = new Vector2(0, 0),
                        t1 = new Vector2(0, 1),
                        t2 = new Vector2(1, 1),
                        c = new Vector4(1, 1, 1, 1)
                    };
                p_mesh[p_index + 1] =
                    new tri()
                    {
                        v0 = new Vector4(p_a, 1),
                        v1 = new Vector4(p_c, 1),
                        v2 = new Vector4(p_d, 1),
                        t0 = new Vector2(0, 0),
                        t1 = new Vector2(1, 1),
                        t2 = new Vector2(1, 0),
                        c = new Vector4(1, 1, 1, 1)
                    };
            }
            void create_rect_prism(ref tri[] p_mesh, int p_index, Vector3 p_a, Vector3 p_b, Vector3 p_c, Vector3 p_d, Vector3 p_e, Vector3 p_f, Vector3 p_g, Vector3 p_h)
            {
                create_rect(ref p_mesh, p_index + 0, p_a, p_b, p_c, p_d);
                create_rect(ref p_mesh, p_index + 2, p_h, p_g, p_f, p_e);
                create_rect(ref p_mesh, p_index + 4, p_e, p_f, p_b, p_a);
                create_rect(ref p_mesh, p_index + 6, p_f, p_g, p_c, p_b);
                create_rect(ref p_mesh, p_index + 8, p_g, p_h, p_d, p_c);
                create_rect(ref p_mesh, p_index + 10, p_a, p_d, p_h, p_e);
            }
            #endregion

            #region Papentable
            {
                item_resource_set Papentable = new item_resource_set();

                #region parts

                #region Surface
                {
                    int index = 0;
                    tri[] mesh = new tri[20];

                    {
                        Vector3 a = new Vector3(0.000f, 0.50f, 0.0f);
                        Vector3 b = new Vector3(0.000f, 0.50f, 1.0f);
                        Vector3 c = new Vector3(0.205f, 0.50f, 1.0f);
                        Vector3 d = new Vector3(0.205f, 0.50f, 0.0f);

                        Vector3 e = new Vector3(0.000f, 0.45f, 0.0f);
                        Vector3 f = new Vector3(0.000f, 0.45f, 1.0f);
                        Vector3 g = new Vector3(0.205f, 0.45f, 1.0f);
                        Vector3 h = new Vector3(0.205f, 0.45f, 0.0f);

                        create_rect(ref mesh, index + 0, a, b, c, d);
                        create_rect(ref mesh, index + 2, h, g, f, e);
                        create_rect(ref mesh, index + 4, e, f, b, a);
                        create_rect(ref mesh, index + 6, f, g, c, b);
                        create_rect(ref mesh, index + 8, a, d, h, e);

                        index += 10;
                    }

                    {
                        Vector3 a = new Vector3(0.295f, 0.50f, 0.0f);
                        Vector3 b = new Vector3(0.295f, 0.50f, 1.0f);
                        Vector3 c = new Vector3(0.500f, 0.50f, 1.0f);
                        Vector3 d = new Vector3(0.500f, 0.50f, 0.0f);

                        Vector3 e = new Vector3(0.295f, 0.45f, 0.0f);
                        Vector3 f = new Vector3(0.295f, 0.45f, 1.0f);
                        Vector3 g = new Vector3(0.500f, 0.45f, 1.0f);
                        Vector3 h = new Vector3(0.500f, 0.45f, 0.0f);

                        create_rect(ref mesh, index + 0, a, b, c, d);
                        create_rect(ref mesh, index + 2, h, g, f, e);
                        create_rect(ref mesh, index + 4, f, g, c, b);
                        create_rect(ref mesh, index + 6, g, h, d, c);
                        create_rect(ref mesh, index + 8, a, d, h, e);

                        index += 10;
                    }

                    part_resource_set surface = new part_resource_set(new mesh(mesh));
                    Papentable.parts.Add("Surface", surface);
                }
                #endregion

                #region Accent
                {
                    int index = 0;
                    tri[] mesh = new tri[8];

                    {
                        Vector3 a = new Vector3(0.205f, 0.50f, 0.0f);
                        Vector3 b = new Vector3(0.205f, 0.50f, 1.0f);
                        Vector3 c = new Vector3(0.295f, 0.50f, 1.0f);
                        Vector3 d = new Vector3(0.295f, 0.50f, 0.0f);

                        Vector3 e = new Vector3(0.205f, 0.45f, 0.0f);
                        Vector3 f = new Vector3(0.205f, 0.45f, 1.0f);
                        Vector3 g = new Vector3(0.295f, 0.45f, 1.0f);
                        Vector3 h = new Vector3(0.295f, 0.45f, 0.0f);

                        create_rect(ref mesh, index + 0, a, b, c, d);
                        create_rect(ref mesh, index + 2, h, g, f, e);
                        create_rect(ref mesh, index + 4, f, g, c, b);
                        create_rect(ref mesh, index + 6, a, d, h, e);

                        index += 8;
                    }

                    part_resource_set accent = new part_resource_set(new mesh(mesh));
                    Papentable.parts.Add("Accent", accent);
                }
                #endregion

                #region Legs
                {
                    int index = 0;
                    tri[] mesh = new tri[48];

                    create_rect_prism(
                        ref mesh, index,
                        new Vector3(0.05f, 0.455f, 0.05f),
                        new Vector3(0.05f, 0.455f, 0.10f),
                        new Vector3(0.10f, 0.455f, 0.10f),
                        new Vector3(0.10f, 0.455f, 0.05f),

                        new Vector3(0.05f, 0.000f, 0.05f),
                        new Vector3(0.05f, 0.000f, 0.10f),
                        new Vector3(0.10f, 0.000f, 0.10f),
                        new Vector3(0.10f, 0.000f, 0.05f)
                        );

                    create_rect_prism(
                        ref mesh, index += 12,
                        new Vector3(0.40f, 0.455f, 0.05f),
                        new Vector3(0.40f, 0.455f, 0.10f),
                        new Vector3(0.45f, 0.455f, 0.10f),
                        new Vector3(0.45f, 0.455f, 0.05f),

                        new Vector3(0.40f, 0.000f, 0.05f),
                        new Vector3(0.40f, 0.000f, 0.10f),
                        new Vector3(0.45f, 0.000f, 0.10f),
                        new Vector3(0.45f, 0.000f, 0.05f)
                        );

                    create_rect_prism(
                        ref mesh, index += 12,
                        new Vector3(0.05f, 0.455f, 0.90f),
                        new Vector3(0.05f, 0.455f, 0.95f),
                        new Vector3(0.10f, 0.455f, 0.95f),
                        new Vector3(0.10f, 0.455f, 0.90f),

                        new Vector3(0.05f, 0.000f, 0.90f),
                        new Vector3(0.05f, 0.000f, 0.95f),
                        new Vector3(0.10f, 0.000f, 0.95f),
                        new Vector3(0.10f, 0.000f, 0.90f)
                        );

                    create_rect_prism(
                        ref mesh, index += 12,
                        new Vector3(0.40f, 0.455f, 0.90f),
                        new Vector3(0.40f, 0.455f, 0.95f),
                        new Vector3(0.45f, 0.455f, 0.95f),
                        new Vector3(0.45f, 0.455f, 0.90f),

                        new Vector3(0.40f, 0.000f, 0.90f),
                        new Vector3(0.40f, 0.000f, 0.95f),
                        new Vector3(0.45f, 0.000f, 0.95f),
                        new Vector3(0.45f, 0.000f, 0.90f)
                        );

                    part_resource_set legs = new part_resource_set(new mesh(mesh));
                    Papentable.parts.Add("Legs", legs);
                }
                #endregion

                #endregion

                #region configurations

                #region spinning
                {
                    render_configuration spinning = new render_configuration();

                    spinning.cam_pos = new Vector3(0, 1, 1);
                    spinning.cam_fwd = Vector3.Transform(new Vector3(0, 0, 1), Matrix4x4.CreateRotationX(-0.6f));
                    spinning.cam_up = Vector3.Cross(spinning.cam_right, spinning.cam_fwd);

                    spinning.buffer_size = sizeof(long) + sizeof(float) + sizeof(Matrix4x4);

                    static void frame_program(void* p_program_buffer)
                    {
                        #region time delta multiplier
                        long last_tick = *(long*)p_program_buffer;
                        *(long*)p_program_buffer = DateTime.Now.Ticks;
                        float ms_delta = (DateTime.Now.Ticks - last_tick) / 10_000f;
                        if (ms_delta > 250)
                            ms_delta = 250;
                        float delta_multiplier = ms_delta / 16.6f;
                        #endregion

                        #region rotation
                        float theta_y = *(float*)((long*)p_program_buffer + 1) + (0.0025f * delta_multiplier);
                        *(float*)((long*)p_program_buffer + 1) = theta_y;

                        Matrix4x4 world =
                            Matrix4x4.CreateTranslation(-0.25f, 0, -0.5f) *
                            Matrix4x4.CreateRotationY(theta_y);

                        *(Matrix4x4*)((float*)((long*)p_program_buffer + 1) + 1) = world;
                        #endregion
                    }
                    spinning.frame_program = &frame_program;

                    static tri scene_tri_program(tri p_tri, void* p_program_buffer)
                    {
                        Matrix4x4 world = *(Matrix4x4*)((float*)((long*)p_program_buffer + 1) + 1);

                        p_tri.v0 = Vector4.Transform(p_tri.v0, world);
                        p_tri.v1 = Vector4.Transform(p_tri.v1, world);
                        p_tri.v2 = Vector4.Transform(p_tri.v2, world);

                        return p_tri;
                    }
                    spinning.tri_program = &scene_tri_program;

                    Papentable.configurations.Add("spinning", spinning);
                }
                #endregion

                #region top
                {
                    render_configuration top = new render_configuration();

                    top.cam_pos = new Vector3(0.25f, 1.8f, 0.5f);
                    top.cam_fwd = new Vector3(0, 1, 0);
                    top.cam_up = new Vector3(0, 0, 1);

                    Papentable.configurations.Add("top", top);
                }
                #endregion

                #region front
                {
                    render_configuration front = new render_configuration();

                    front.cam_pos = new Vector3(0.25f, 0.3f, 1.8f);
                    front.cam_fwd = new Vector3(0, 0, 1);
                    front.cam_up = new Vector3(0, 1, 0);

                    Papentable.configurations.Add("front", front);
                }
                #endregion

                #region side
                {
                    render_configuration side = new render_configuration();

                    side.cam_pos = new Vector3(1.5f, 0.3f, 0.5f);
                    side.cam_fwd = new Vector3(1, 0, 0);
                    side.cam_up = new Vector3(0, 1, 0);
                    side.cam_right = new Vector3(0, 0, 1);

                    Papentable.configurations.Add("side", side);
                }
                #endregion

                #endregion

                items.Add("Papentable", Papentable);
            }
            #endregion

            #region Schlupenseaten
            {
                item_resource_set Schlupenseaten = new item_resource_set();

                #region parts

                #region Seat
                {
                    int index = 0;
                    tri[] mesh = new tri[24];

                    create_rect_prism(
                        ref mesh, index,
                        new Vector3(0.00000f, 0.300f, 0.00f),
                        new Vector3(0.00000f, 0.300f, 0.25f),
                        new Vector3(0.22825f, 0.300f, 0.25f),
                        new Vector3(0.22825f, 0.300f, 0.00f),

                        new Vector3(0.000f, 0.275f, 0.00f),
                        new Vector3(0.000f, 0.275f, 0.25f),
                        new Vector3(0.225f, 0.275f, 0.25f),
                        new Vector3(0.225f, 0.275f, 0.00f)
                        );

                    create_rect_prism(
                        ref mesh, index += 12,
                        new Vector3(0.250f, 0.600f, 0.00f),
                        new Vector3(0.250f, 0.600f, 0.25f),
                        new Vector3(0.275f, 0.600f, 0.25f),
                        new Vector3(0.275f, 0.600f, 0.00f),

                        new Vector3(0.225f, 0.275f, 0.00f),
                        new Vector3(0.225f, 0.275f, 0.25f),
                        new Vector3(0.250f, 0.275f, 0.25f),
                        new Vector3(0.250f, 0.275f, 0.00f)
                        );

                    part_resource_set seat = new part_resource_set(new mesh(mesh));
                    Schlupenseaten.parts.Add("Seat", seat);
                }
                #endregion

                #region Legs
                {
                    int index = 0;
                    tri[] mesh = new tri[48];

                    create_rect_prism(
                        ref mesh, index,
                        new Vector3(0.01f, 0.28f, 0.01f),
                        new Vector3(0.01f, 0.28f, 0.04f),
                        new Vector3(0.04f, 0.28f, 0.04f),
                        new Vector3(0.04f, 0.28f, 0.01f),

                        new Vector3(0.01f, 0.00f, 0.01f),
                        new Vector3(0.01f, 0.00f, 0.04f),
                        new Vector3(0.04f, 0.00f, 0.04f),
                        new Vector3(0.04f, 0.00f, 0.01f)
                        );

                    create_rect_prism(
                        ref mesh, index += 12,
                        new Vector3(0.01f, 0.28f, 0.21f),
                        new Vector3(0.01f, 0.28f, 0.24f),
                        new Vector3(0.04f, 0.28f, 0.24f),
                        new Vector3(0.04f, 0.28f, 0.21f),

                        new Vector3(0.01f, 0.00f, 0.21f),
                        new Vector3(0.01f, 0.00f, 0.24f),
                        new Vector3(0.04f, 0.00f, 0.24f),
                        new Vector3(0.04f, 0.00f, 0.21f)
                        );

                    create_rect_prism(
                        ref mesh, index += 12,
                        new Vector3(0.21f, 0.28f, 0.01f),
                        new Vector3(0.21f, 0.28f, 0.04f),
                        new Vector3(0.24f, 0.28f, 0.04f),
                        new Vector3(0.24f, 0.28f, 0.01f),

                        new Vector3(0.21f, 0.00f, 0.01f),
                        new Vector3(0.21f, 0.00f, 0.04f),
                        new Vector3(0.24f, 0.00f, 0.04f),
                        new Vector3(0.24f, 0.00f, 0.01f)
                        );

                    create_rect_prism(
                        ref mesh, index += 12,
                        new Vector3(0.21f, 0.28f, 0.21f),
                        new Vector3(0.21f, 0.28f, 0.24f),
                        new Vector3(0.24f, 0.28f, 0.24f),
                        new Vector3(0.24f, 0.28f, 0.21f),

                        new Vector3(0.21f, 0.00f, 0.21f),
                        new Vector3(0.21f, 0.00f, 0.24f),
                        new Vector3(0.24f, 0.00f, 0.24f),
                        new Vector3(0.24f, 0.00f, 0.21f)
                        );

                    part_resource_set legs = new part_resource_set(new mesh(mesh));
                    Schlupenseaten.parts.Add("Legs", legs);
                }
                #endregion

                #endregion

                #region configurations

                #region spinning
                {
                    render_configuration spinning = new render_configuration();

                    spinning.cam_pos = new Vector3(0, 0.8f, 0.6f);
                    spinning.cam_fwd = Vector3.Transform(new Vector3(0, 0, 1), Matrix4x4.CreateRotationX(-0.6f));
                    spinning.cam_up = Vector3.Cross(spinning.cam_right, spinning.cam_fwd);

                    spinning.buffer_size = sizeof(long) + sizeof(float) + sizeof(Matrix4x4);

                    static void frame_program(void* p_program_buffer)
                    {
                        #region time delta multiplier
                        long last_tick = *(long*)p_program_buffer;
                        *(long*)p_program_buffer = DateTime.Now.Ticks;
                        float ms_delta = (DateTime.Now.Ticks - last_tick) / 10_000f;
                        if (ms_delta > 250)
                            ms_delta = 250;
                        float delta_multiplier = ms_delta / 16.6f;
                        #endregion

                        #region rotation
                        float theta_y = *(float*)((long*)p_program_buffer + 1) + (0.0025f * delta_multiplier);
                        *(float*)((long*)p_program_buffer + 1) = theta_y;

                        Matrix4x4 world =
                            Matrix4x4.CreateTranslation(-0.125f, 0, -0.125f) *
                            Matrix4x4.CreateRotationY(theta_y);

                        *(Matrix4x4*)((float*)((long*)p_program_buffer + 1) + 1) = world;
                        #endregion
                    }
                    spinning.frame_program = &frame_program;

                    static tri scene_tri_program(tri p_tri, void* p_program_buffer)
                    {
                        Matrix4x4 world = *(Matrix4x4*)((float*)((long*)p_program_buffer + 1) + 1);

                        p_tri.v0 = Vector4.Transform(p_tri.v0, world);
                        p_tri.v1 = Vector4.Transform(p_tri.v1, world);
                        p_tri.v2 = Vector4.Transform(p_tri.v2, world);

                        return p_tri;
                    }
                    spinning.tri_program = &scene_tri_program;

                    Schlupenseaten.configurations.Add("spinning", spinning);
                }
                #endregion

                #region top
                {
                    render_configuration top = new render_configuration();

                    top.cam_pos = new Vector3(0.125f, 1, 0.125f);
                    top.cam_fwd = new Vector3(0, 1, 0);
                    top.cam_up = new Vector3(0, 0, 1);

                    Schlupenseaten.configurations.Add("top", top);
                }
                #endregion

                #region front
                {
                    render_configuration front = new render_configuration();

                    front.cam_pos = new Vector3(0.125f, 0.3f, 1);
                    front.cam_fwd = new Vector3(0, 0, 1);
                    front.cam_up = new Vector3(0, 1, 0);

                    Schlupenseaten.configurations.Add("front", front);
                }
                #endregion

                #region side
                {
                    render_configuration side = new render_configuration();

                    side.cam_pos = new Vector3(-0.8f, 0.3f, 0.125f);
                    side.cam_fwd = new Vector3(-1, 0, 0);
                    side.cam_up = new Vector3(0, 1, 0);
                    side.cam_right = new Vector3(0, 0, -1);

                    side.light_direction = Vector3.Normalize(new Vector3(-1, 1, 1));

                    Schlupenseaten.configurations.Add("side", side);
                }
                #endregion

                #endregion

                items.Add("Schlupenseaten", Schlupenseaten);
            }
            #endregion

            #region Atabenche
            {
                item_resource_set Atabenche = new item_resource_set();

                #region parts

                #region Seat
                {
                    int index = 0;
                    tri[] mesh = new tri[12];

                    create_rect_prism(
                        ref mesh, index,
                        new Vector3(0.00f, 0.300f, 0.0f),
                        new Vector3(0.00f, 0.300f, 0.8f),
                        new Vector3(0.25f, 0.300f, 0.8f),
                        new Vector3(0.25f, 0.300f, 0.0f),

                        new Vector3(0.00f, 0.275f, 0.0f),
                        new Vector3(0.00f, 0.275f, 0.8f),
                        new Vector3(0.25f, 0.275f, 0.8f),
                        new Vector3(0.25f, 0.275f, 0.0f)
                        );

                    part_resource_set seat = new part_resource_set(new mesh(mesh));
                    Atabenche.parts.Add("Seat", seat);
                }
                #endregion

                #region Legs
                {
                    int index = 0;
                    tri[] mesh = new tri[48];

                    create_rect_prism(
                        ref mesh, index,
                        new Vector3(0.01f, 0.28f, 0.04f),
                        new Vector3(0.01f, 0.28f, 0.07f),
                        new Vector3(0.04f, 0.28f, 0.07f),
                        new Vector3(0.04f, 0.28f, 0.04f),

                        new Vector3(0.21f, 0.00f, 0.04f),
                        new Vector3(0.21f, 0.00f, 0.07f),
                        new Vector3(0.24f, 0.00f, 0.07f),
                        new Vector3(0.24f, 0.00f, 0.04f)
                        );

                    create_rect_prism(
                        ref mesh, index += 12,
                        new Vector3(0.01f, 0.28f, 0.73f),
                        new Vector3(0.01f, 0.28f, 0.76f),
                        new Vector3(0.04f, 0.28f, 0.76f),
                        new Vector3(0.04f, 0.28f, 0.73f),

                        new Vector3(0.21f, 0.00f, 0.73f),
                        new Vector3(0.21f, 0.00f, 0.76f),
                        new Vector3(0.24f, 0.00f, 0.76f),
                        new Vector3(0.24f, 0.00f, 0.73f)
                        );

                    create_rect_prism(
                        ref mesh, index += 12,
                        new Vector3(0.21f, 0.28f, 0.01f),
                        new Vector3(0.21f, 0.28f, 0.04f),
                        new Vector3(0.24f, 0.28f, 0.04f),
                        new Vector3(0.24f, 0.28f, 0.01f),

                        new Vector3(0.01f, 0.00f, 0.01f),
                        new Vector3(0.01f, 0.00f, 0.04f),
                        new Vector3(0.04f, 0.00f, 0.04f),
                        new Vector3(0.04f, 0.00f, 0.01f)
                        );

                    create_rect_prism(
                        ref mesh, index += 12,
                        new Vector3(0.21f, 0.28f, 0.76f),
                        new Vector3(0.21f, 0.28f, 0.79f),
                        new Vector3(0.24f, 0.28f, 0.79f),
                        new Vector3(0.24f, 0.28f, 0.76f),

                        new Vector3(0.01f, 0.00f, 0.76f),
                        new Vector3(0.01f, 0.00f, 0.79f),
                        new Vector3(0.04f, 0.00f, 0.79f),
                        new Vector3(0.04f, 0.00f, 0.76f)
                        );

                    part_resource_set legs = new part_resource_set(new mesh(mesh));
                    Atabenche.parts.Add("Legs", legs);
                }
                #endregion

                #endregion

                #region configurations

                #region spinning
                {
                    render_configuration spinning = new render_configuration();

                    spinning.cam_pos = new Vector3(0, 0.9f, 0.9f);
                    spinning.cam_fwd = Vector3.Transform(new Vector3(0, 0, 1), Matrix4x4.CreateRotationX(-0.6f));
                    spinning.cam_up = Vector3.Cross(spinning.cam_right, spinning.cam_fwd);

                    spinning.buffer_size = sizeof(long) + sizeof(float) + sizeof(Matrix4x4);

                    static void frame_program(void* p_program_buffer)
                    {
                        #region time delta multiplier
                        long last_tick = *(long*)p_program_buffer;
                        *(long*)p_program_buffer = DateTime.Now.Ticks;
                        float ms_delta = (DateTime.Now.Ticks - last_tick) / 10_000f;
                        if (ms_delta > 250)
                            ms_delta = 250;
                        float delta_multiplier = ms_delta / 16.6f;
                        #endregion

                        #region rotation
                        float theta_y = *(float*)((long*)p_program_buffer + 1) + (0.0025f * delta_multiplier);
                        *(float*)((long*)p_program_buffer + 1) = theta_y;

                        Matrix4x4 world =
                            Matrix4x4.CreateTranslation(-0.125f, 0, -0.4f) *
                            Matrix4x4.CreateRotationY(theta_y);

                        *(Matrix4x4*)((float*)((long*)p_program_buffer + 1) + 1) = world;
                        #endregion
                    }
                    spinning.frame_program = &frame_program;

                    static tri scene_tri_program(tri p_tri, void* p_program_buffer)
                    {
                        Matrix4x4 world = *(Matrix4x4*)((float*)((long*)p_program_buffer + 1) + 1);

                        p_tri.v0 = Vector4.Transform(p_tri.v0, world);
                        p_tri.v1 = Vector4.Transform(p_tri.v1, world);
                        p_tri.v2 = Vector4.Transform(p_tri.v2, world);

                        return p_tri;
                    }
                    spinning.tri_program = &scene_tri_program;

                    Atabenche.configurations.Add("spinning", spinning);
                }
                #endregion

                #region top
                {
                    render_configuration top = new render_configuration();

                    top.cam_pos = new Vector3(0.125f, 1.5f, 0.4f);
                    top.cam_fwd = new Vector3(0, 1, 0);
                    top.cam_up = new Vector3(0, 0, 1);

                    Atabenche.configurations.Add("top", top);
                }
                #endregion

                #region front
                {
                    render_configuration front = new render_configuration();

                    front.cam_pos = new Vector3(0.125f, 0.25f, 1.25f);
                    front.cam_fwd = new Vector3(0, 0, 1);
                    front.cam_up = new Vector3(0, 1, 0);

                    Atabenche.configurations.Add("front", front);
                }
                #endregion

                #region side
                {
                    render_configuration side = new render_configuration();

                    side.cam_pos = new Vector3(1, 0.25f, 0.4f);
                    side.cam_fwd = new Vector3(1, 0, 0);
                    side.cam_up = new Vector3(0, 1, 0);
                    side.cam_right = new Vector3(0, 0, 1);

                    Atabenche.configurations.Add("side", side);
                }
                #endregion

                #endregion

                items.Add("Atabenche", Atabenche);
            }
            #endregion

            #region Bunkschlef
            {
                item_resource_set Bunkschlef = new item_resource_set();

                #region parts

                #region Body
                {
                    int index = 0;
                    tri[] mesh = new tri[24];

                    create_rect_prism(
                        ref mesh, index,
                        new Vector3(0.00f, 1, 0.00f),
                        new Vector3(0.00f, 1, 0.25f),
                        new Vector3(0.04f, 1, 0.25f),
                        new Vector3(0.04f, 1, 0.00f),

                        new Vector3(0.00f, 0, 0.00f),
                        new Vector3(0.00f, 0, 0.25f),
                        new Vector3(0.04f, 0, 0.25f),
                        new Vector3(0.04f, 0, 0.00f)
                        );

                    create_rect_prism(
                        ref mesh, index += 12,
                        new Vector3(0.46f, 1, 0.00f),
                        new Vector3(0.46f, 1, 0.25f),
                        new Vector3(0.50f, 1, 0.25f),
                        new Vector3(0.50f, 1, 0.00f),

                        new Vector3(0.46f, 0, 0.00f),
                        new Vector3(0.46f, 0, 0.25f),
                        new Vector3(0.50f, 0, 0.25f),
                        new Vector3(0.50f, 0, 0.00f)
                        );

                    part_resource_set body = new part_resource_set(new mesh(mesh));
                    Bunkschlef.parts.Add("Body", body);
                }
                #endregion

                #region Shelves
                {
                    int index = 0;
                    tri[] mesh = new tri[60];

                    create_rect_prism(
                        ref mesh, index,
                        new Vector3(0.03f, 0.90f, 0.005f),
                        new Vector3(0.03f, 0.90f, 0.245f),
                        new Vector3(0.47f, 0.90f, 0.245f),
                        new Vector3(0.47f, 0.90f, 0.005f),

                        new Vector3(0.03f, 0.87f, 0.005f),
                        new Vector3(0.03f, 0.87f, 0.245f),
                        new Vector3(0.47f, 0.87f, 0.245f),
                        new Vector3(0.47f, 0.87f, 0.005f)
                        );

                    create_rect_prism(
                        ref mesh, index += 12,
                        new Vector3(0.03f, 0.70f, 0.005f),
                        new Vector3(0.03f, 0.70f, 0.245f),
                        new Vector3(0.47f, 0.70f, 0.245f),
                        new Vector3(0.47f, 0.70f, 0.005f),

                        new Vector3(0.03f, 0.67f, 0.005f),
                        new Vector3(0.03f, 0.67f, 0.245f),
                        new Vector3(0.47f, 0.67f, 0.245f),
                        new Vector3(0.47f, 0.67f, 0.005f)
                        );

                    create_rect_prism(
                        ref mesh, index += 12,
                        new Vector3(0.03f, 0.50f, 0.005f),
                        new Vector3(0.03f, 0.50f, 0.245f),
                        new Vector3(0.47f, 0.50f, 0.245f),
                        new Vector3(0.47f, 0.50f, 0.005f),

                        new Vector3(0.03f, 0.47f, 0.005f),
                        new Vector3(0.03f, 0.47f, 0.245f),
                        new Vector3(0.47f, 0.47f, 0.245f),
                        new Vector3(0.47f, 0.47f, 0.005f)
                        );

                    create_rect_prism(
                        ref mesh, index += 12,
                        new Vector3(0.03f, 0.30f, 0.005f),
                        new Vector3(0.03f, 0.30f, 0.245f),
                        new Vector3(0.47f, 0.30f, 0.245f),
                        new Vector3(0.47f, 0.30f, 0.005f),

                        new Vector3(0.03f, 0.27f, 0.005f),
                        new Vector3(0.03f, 0.27f, 0.245f),
                        new Vector3(0.47f, 0.27f, 0.245f),
                        new Vector3(0.47f, 0.27f, 0.005f)
                        );

                    create_rect_prism(
                        ref mesh, index += 12,
                        new Vector3(0.03f, 0.10f, 0.005f),
                        new Vector3(0.03f, 0.10f, 0.245f),
                        new Vector3(0.47f, 0.10f, 0.245f),
                        new Vector3(0.47f, 0.10f, 0.005f),

                        new Vector3(0.03f, 0.07f, 0.005f),
                        new Vector3(0.03f, 0.07f, 0.245f),
                        new Vector3(0.47f, 0.07f, 0.245f),
                        new Vector3(0.47f, 0.07f, 0.005f)
                        );

                    part_resource_set shelves = new part_resource_set(new mesh(mesh));
                    Bunkschlef.parts.Add("Shelves", shelves);
                }
                #endregion

                #endregion

                #region configuration

                #region spinning
                {
                    render_configuration spinning = new render_configuration();

                    spinning.cam_pos = new Vector3(0, 1.25f, 1);
                    spinning.cam_fwd = Vector3.Transform(new Vector3(0, 0, 1), Matrix4x4.CreateRotationX(-0.6f));
                    spinning.cam_up = Vector3.Cross(spinning.cam_right, spinning.cam_fwd);

                    spinning.buffer_size = sizeof(long) + sizeof(float) + sizeof(Matrix4x4);

                    static void frame_program(void* p_program_buffer)
                    {
                        #region time delta multiplier
                        long last_tick = *(long*)p_program_buffer;
                        *(long*)p_program_buffer = DateTime.Now.Ticks;
                        float ms_delta = (DateTime.Now.Ticks - last_tick) / 10_000f;
                        if (ms_delta > 250)
                            ms_delta = 250;
                        float delta_multiplier = ms_delta / 16.6f;
                        #endregion

                        #region rotation
                        float theta_y = *(float*)((long*)p_program_buffer + 1) + (0.0025f * delta_multiplier);
                        *(float*)((long*)p_program_buffer + 1) = theta_y;

                        Matrix4x4 world =
                            Matrix4x4.CreateTranslation(-0.25f, 0, -0.125f) *
                            Matrix4x4.CreateRotationY(MathF.PI / 2 + theta_y);

                        *(Matrix4x4*)((float*)((long*)p_program_buffer + 1) + 1) = world;
                        #endregion
                    }
                    spinning.frame_program = &frame_program;

                    static tri scene_tri_program(tri p_tri, void* p_program_buffer)
                    {
                        Matrix4x4 world = *(Matrix4x4*)((float*)((long*)p_program_buffer + 1) + 1);

                        p_tri.v0 = Vector4.Transform(p_tri.v0, world);
                        p_tri.v1 = Vector4.Transform(p_tri.v1, world);
                        p_tri.v2 = Vector4.Transform(p_tri.v2, world);

                        return p_tri;
                    }
                    spinning.tri_program = &scene_tri_program;

                    Bunkschlef.configurations.Add("spinning", spinning);
                }
                #endregion

                #region top
                {
                    render_configuration top = new render_configuration();

                    top.cam_pos = new Vector3(0.25f, 2, 0.125f);
                    top.cam_fwd = new Vector3(0, 1, 0);
                    top.cam_up = new Vector3(0, 0, 1);

                    Bunkschlef.configurations.Add("top", top);
                }
                #endregion

                #region front
                {
                    render_configuration front = new render_configuration();

                    front.cam_pos = new Vector3(1.5f, 0.5f, 0.25f);
                    front.cam_fwd = new Vector3(1, 0, 0);
                    front.cam_up = new Vector3(0, 1, 0);
                    front.cam_right = new Vector3(0, 0, 1);

                    Bunkschlef.configurations.Add("front", front);
                }
                #endregion

                #region side
                {
                    render_configuration side = new render_configuration();

                    side.cam_pos = new Vector3(0.25f, 0.5f, 1.8f);
                    side.cam_fwd = new Vector3(0, 0, 1);
                    side.cam_up = new Vector3(0, 1, 0);

                    Bunkschlef.configurations.Add("side", side);
                }
                #endregion

                #endregion

                items.Add("Bunkschlef", Bunkschlef);
            }
            #endregion

            #region Bettabel
            {
                item_resource_set Bettabel = new item_resource_set();

                #region parts

                #region Body
                {
                    int index = 0;
                    tri[] mesh = new tri[48];

                    create_rect_prism(
                        ref mesh, index,
                        new Vector3(0.00f, 0.3f, 0.0f),
                        new Vector3(0.00f, 0.3f, 0.3f),
                        new Vector3(0.03f, 0.3f, 0.3f),
                        new Vector3(0.03f, 0.3f, 0.0f),

                        new Vector3(0.00f, 0.0f, 0.0f),
                        new Vector3(0.00f, 0.0f, 0.3f),
                        new Vector3(0.03f, 0.0f, 0.3f),
                        new Vector3(0.03f, 0.0f, 0.0f)
                        );

                    create_rect_prism(
                        ref mesh, index += 12,
                        new Vector3(0.27f, 0.3f, 0.0f),
                        new Vector3(0.27f, 0.3f, 0.3f),
                        new Vector3(0.30f, 0.3f, 0.3f),
                        new Vector3(0.30f, 0.3f, 0.0f),

                        new Vector3(0.27f, 0.0f, 0.0f),
                        new Vector3(0.27f, 0.0f, 0.3f),
                        new Vector3(0.30f, 0.0f, 0.3f),
                        new Vector3(0.30f, 0.0f, 0.0f)
                        );

                    create_rect_prism(
                        ref mesh, index += 12,
                        new Vector3(0.01f, 0.30f, 0.26f),
                        new Vector3(0.01f, 0.30f, 0.29f),
                        new Vector3(0.29f, 0.30f, 0.29f),
                        new Vector3(0.29f, 0.30f, 0.26f),

                        new Vector3(0.01f, 0.08f, 0.26f),
                        new Vector3(0.01f, 0.08f, 0.29f),
                        new Vector3(0.29f, 0.08f, 0.29f),
                        new Vector3(0.29f, 0.08f, 0.26f)
                        );

                    create_rect_prism(
                        ref mesh, index += 12,
                        new Vector3(0.01f, 0.20f, 0.01f),
                        new Vector3(0.01f, 0.20f, 0.28f),
                        new Vector3(0.29f, 0.20f, 0.28f),
                        new Vector3(0.29f, 0.20f, 0.01f),

                        new Vector3(0.01f, 0.18f, 0.01f),
                        new Vector3(0.01f, 0.18f, 0.28f),
                        new Vector3(0.29f, 0.18f, 0.28f),
                        new Vector3(0.29f, 0.18f, 0.01f)
                        );

                    part_resource_set body = new part_resource_set(new mesh(mesh));
                    Bettabel.parts.Add("Body", body);
                }
                #endregion

                #region Surface
                {
                    int index = 0;
                    tri[] mesh = new tri[12];

                    create_rect_prism(
                        ref mesh, index,
                        new Vector3(-0.03f, 0.33f, -0.03f),
                        new Vector3(-0.03f, 0.33f, +0.33f),
                        new Vector3(+0.33f, 0.33f, +0.33f),
                        new Vector3(+0.33f, 0.33f, -0.03f),

                        new Vector3(-0.03f, 0.29f, -0.03f),
                        new Vector3(-0.03f, 0.29f, +0.33f),
                        new Vector3(+0.33f, 0.29f, +0.33f),
                        new Vector3(+0.33f, 0.29f, -0.03f)
                        );

                    part_resource_set surface = new part_resource_set(new mesh(mesh));
                    Bettabel.parts.Add("Surface", surface);
                }
                #endregion

                #region Drawer
                {
                    int index = 0;
                    tri[] mesh = new tri[12];

                    create_rect_prism(
                        ref mesh, index,
                        new Vector3(0.01f, 0.30f, 0.015f),
                        new Vector3(0.01f, 0.30f, 0.045f),
                        new Vector3(0.29f, 0.30f, 0.045f),
                        new Vector3(0.29f, 0.30f, 0.015f),

                        new Vector3(0.01f, 0.17f, 0.015f),
                        new Vector3(0.01f, 0.17f, 0.045f),
                        new Vector3(0.29f, 0.17f, 0.045f),
                        new Vector3(0.29f, 0.17f, 0.015f)
                        );

                    part_resource_set drawer = new part_resource_set(new mesh(mesh));
                    Bettabel.parts.Add("Drawer", drawer);
                }
                #endregion

                #endregion

                #region configurations

                #region spinning
                {
                    render_configuration spinning = new render_configuration();

                    spinning.cam_pos = new Vector3(0, 0.7f, 0.6f);
                    spinning.cam_fwd = Vector3.Transform(new Vector3(0, 0, 1), Matrix4x4.CreateRotationX(-0.6f));
                    spinning.cam_up = Vector3.Cross(spinning.cam_right, spinning.cam_fwd);

                    spinning.buffer_size = sizeof(long) + sizeof(float) + sizeof(Matrix4x4);

                    static void frame_program(void* p_program_buffer)
                    {
                        #region time delta multiplier
                        long last_tick = *(long*)p_program_buffer;
                        *(long*)p_program_buffer = DateTime.Now.Ticks;
                        float ms_delta = (DateTime.Now.Ticks - last_tick) / 10_000f;
                        if (ms_delta > 250)
                            ms_delta = 250;
                        float delta_multiplier = ms_delta / 16.6f;
                        #endregion

                        #region rotation
                        float theta_y = *(float*)((long*)p_program_buffer + 1) + (0.0025f * delta_multiplier);
                        *(float*)((long*)p_program_buffer + 1) = theta_y;

                        Matrix4x4 world =
                            Matrix4x4.CreateTranslation(-0.15f, 0, -0.15f) *
                            Matrix4x4.CreateRotationY(MathF.PI / 2 + theta_y);

                        *(Matrix4x4*)((float*)((long*)p_program_buffer + 1) + 1) = world;
                        #endregion
                    }
                    spinning.frame_program = &frame_program;

                    static tri scene_tri_program(tri p_tri, void* p_program_buffer)
                    {
                        Matrix4x4 world = *(Matrix4x4*)((float*)((long*)p_program_buffer + 1) + 1);

                        p_tri.v0 = Vector4.Transform(p_tri.v0, world);
                        p_tri.v1 = Vector4.Transform(p_tri.v1, world);
                        p_tri.v2 = Vector4.Transform(p_tri.v2, world);

                        return p_tri;
                    }
                    spinning.tri_program = &scene_tri_program;

                    Bettabel.configurations.Add("spinning", spinning);
                }
                #endregion

                #region top
                {
                    render_configuration top = new render_configuration();

                    top.cam_pos = new Vector3(0.125f, 1, 0.125f);
                    top.cam_fwd = new Vector3(0, 1, 0);
                    top.cam_up = new Vector3(0, 0, 1);

                    Bettabel.configurations.Add("top", top);
                }
                #endregion

                #region front
                {
                    render_configuration front = new render_configuration();

                    front.cam_pos = new Vector3(0.15f, 0.125f, -0.6f);
                    front.cam_fwd = new Vector3(0, 0, -1);
                    front.cam_up = new Vector3(0, 1, 0);
                    front.cam_right = new Vector3(1, 0, 0);

                    front.light_direction = Vector3.Normalize(new Vector3(1, 1, -1));

                    Bettabel.configurations.Add("front", front);
                }
                #endregion

                #region side
                {
                    render_configuration side = new render_configuration();

                    side.cam_pos = new Vector3(1, 0.125f, 0.125f);
                    side.cam_fwd = new Vector3(1, 0, 0);
                    side.cam_up = new Vector3(0, 1, 0);
                    side.cam_right = new Vector3(0, 0, 1);

                    Bettabel.configurations.Add("side", side);
                }
                #endregion

                #endregion

                items.Add("Bettabel", Bettabel);
            }
            #endregion

            #endregion

            #region icons

            material_icons.Add("Wood 1", new Bitmap("resources/icons/wood_1.jpg"));
            material_icons.Add("Wood 2", new Bitmap("resources/icons/wood_2.jpg"));
            material_icons.Add("Wood 3", new Bitmap("resources/icons/wood_3.jpg"));
            material_icons.Add("Wood 4", new Bitmap("resources/icons/wood_4.jpg"));
            material_icons.Add("Wood 5", new Bitmap("resources/icons/wood_5.jpg"));

            material_icons.Add("Aluminium", new Bitmap("resources/icons/aluminium.jpg"));
            material_icons.Add("Gold", new Bitmap("resources/icons/gold.jpg"));
            material_icons.Add("Steel", new Bitmap("resources/icons/steel.jpg"));

            material_icons.Add("White marble", new Bitmap("resources/icons/white_marble.jpg"));
            material_icons.Add("Black marble", new Bitmap("resources/icons/black_marble.jpg"));
            material_icons.Add("Beige marble", new Bitmap("resources/icons/beige_marble.jpg"));

            material_icons.Add("Leather", new Bitmap("resources/icons/leather.jpg"));
            material_icons.Add("Fabric", new Bitmap("resources/icons/fabric.png"));

            #endregion

            #region textures

            textures.Add("Wood 1", new texture("resources/textures/wood_1.jpg"));
            textures.Add("Wood 2", new texture("resources/textures/wood_2.jpg"));
            textures.Add("Wood 3", new texture("resources/textures/wood_3.jpg"));
            textures.Add("Wood 4", new texture("resources/textures/wood_4.jpg"));
            textures.Add("Wood 5", new texture("resources/textures/wood_5.jpg"));

            textures.Add("Aluminium", new texture("resources/textures/aluminium.jpg"));
            textures.Add("Gold", new texture("resources/textures/gold.jpg"));
            textures.Add("Steel", new texture("resources/textures/steel.jpg"));

            textures.Add("White marble", new texture("resources/textures/white_marble.jpg"));
            textures.Add("Black marble", new texture("resources/textures/black_marble.jpg"));
            textures.Add("Beige marble", new texture("resources/textures/beige_marble.jpg"));

            textures.Add("Leather", new texture("resources/textures/leather.jpg"));
            textures.Add("Fabric", new texture("resources/textures/fabric.png"));

            #endregion
        }

        public UserControl get_page(string p_name)
        {
            return pages[p_name];
        }
        public void add_page(string p_name, UserControl p_page)
        {
            if (p_page != null && !pages.ContainsKey(p_name))
                pages.Add(p_name, p_page);
        }
        public void remove_page(string p_name)
        {
            if (pages.ContainsKey(p_name))
                pages.Remove(p_name);
        }
        public void set_page(string p_name)
        {
            if (pages.ContainsKey(p_name))
            {
                if (current_page != null && !current_page.IsDisposed)
                    current_page.Hide();

                Controls.Clear();

                current_page = pages[p_name];
                Controls.Add(current_page);
                current_page.Show();
            }
        }
        public void set_page(UserControl p_page)
        {
            if (current_page != null && !current_page.IsDisposed)
                current_page.Hide();

            Controls.Clear();

            current_page = p_page;
            Controls.Add(current_page);
            current_page.Show();
        }

        private void closing(object sender, FormClosingEventArgs e)
        {
            db_connection.Close();
        }
    }
}
