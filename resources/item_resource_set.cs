using System.Collections.Generic;

namespace furniture_store.resources
{
    unsafe public class item_resource_set
    {
        public Dictionary<string, part_resource_set> parts;

        public Dictionary<string, render_configuration> configurations;
        public item_resource_set()
        {
            parts = new Dictionary<string, part_resource_set>();
            configurations = new Dictionary<string, render_configuration>();    
        }
    }
}
