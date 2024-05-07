namespace furniture_store.database_types
{
    public struct build_part
    {
        public part part;
        public material material;
        public build_part(part p_part, material p_material)
        {
            part = p_part;
            material = p_material;
        }
    }
}
