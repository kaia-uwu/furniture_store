using System.Collections.Generic;

namespace furniture_store.database_types
{
    public class item
    {
        public string name;
        public decimal price;
        public List<part> parts;
        public uint id;
        public item(string p_name, decimal p_price, uint p_id) 
        { 
            name = p_name;
            price = p_price;
            parts = new List<part>();
            id = p_id;
        }
    }
}
