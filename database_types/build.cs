using System.Collections.Generic;

namespace furniture_store.database_types
{
    public class build
    {
        public item item;
        public List<build_part> parts;
        public bool is_default;
        public uint id;
        public build(build p_build, build_part p_altered_build_part)
        {
            item = p_build.item;

            parts = new List<build_part>();
            foreach (build_part part in p_build.parts)
                if (part.part != p_altered_build_part.part)
                {
                    parts.Add(part);
                }
                else
                    parts.Add(p_altered_build_part);
        }
        public build(item p_item, bool p_is_default, uint p_id)
        {
            item = p_item;
            parts = new List<build_part>();
            is_default = p_is_default;
            id = p_id;
        }

        public bool compare_similar(build p_build)
        {
            if (item != p_build.item || parts.Count != p_build.parts.Count)
                return false;

            for (int i = 0; i < parts.Count; i++)
                if (parts[i].part != p_build.parts[i].part || 
                    parts[i].material != p_build.parts[i].material)
                    return false;

            return true;
        }
    }
}
