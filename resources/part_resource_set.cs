using min3d_Forms_Edition_Multipanel_Library;

namespace furniture_store.resources
{
    unsafe public class part_resource_set
    {
        public mesh mesh;
        public delegate*<tri, void*, tri> tri_program = &textured_mesh.default_tri_program;
        public part_resource_set(mesh p_mesh)
        {
            mesh = p_mesh;
        }
    }
}
