namespace furniture_store.database_types
{
    public class user
    {
        public string username;
        public string password;
        public string? first_name;
        public string? last_name;
        public string? phone_number;
        public uint id;
        public user(
            string p_username,
            string p_password,
            string? p_first_name,
            string? p_last_name,
            string? p_phone_number,
            uint p_id) 
        { 
            username = p_username;
            password = p_password;
            first_name = p_first_name;
            last_name = p_last_name;
            phone_number = p_phone_number;
            id = p_id;
        }

    }
}
