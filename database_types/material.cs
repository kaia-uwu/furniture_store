namespace furniture_store.database_types
{
    public class material
    {
        public string name;
        public decimal added_price;
        public uint id;
        public material(string p_name, decimal p_added_price, uint p_id)
        {
            name = p_name;
            added_price = p_added_price;
            id = p_id;
        }
    }
}

