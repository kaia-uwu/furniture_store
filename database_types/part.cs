using System.Collections.Generic;

namespace furniture_store.database_types
{
    public class part
    {
        public string name;
        public List<material> materials;
        public uint id;
        public part(string p_name, uint p_id) 
        { 
            name = p_name;
            materials = new List<material>();
            id = p_id;
        }
    }
}
