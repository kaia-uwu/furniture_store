using System;
using System.Numerics;

using min3d_Forms_Edition_Multipanel_Library;

namespace furniture_store.resources
{
    unsafe public class render_configuration
    {
        public Vector3 cam_pos = Vector3.Zero;
        public Vector3 cam_fwd = new Vector3(0, 0, 1);
        public Vector3 cam_up = new Vector3(0, 1, 0);
        public Vector3 cam_right = new Vector3(-1, 0, 0);

        public Vector3 light_direction = Vector3.Normalize(new Vector3(1, 1, 1));

        public float fov = 60 * (MathF.PI / 180);

        public int buffer_size = 0;
        public delegate*<void*, void> frame_program = &render_instance.default_frame_program;
        public delegate*<tri, void*, tri> tri_program = &render_instance.default_tri_program;
    }
}
