namespace Hotel_El_Dorado_Admin.Models
{
    public sealed class Cache
    {
        private readonly static Cache _instance = new Cache();

        public  bool isLogged { get; set; }
        private Cache()
        {
            isLogged = false;
        }

        public static Cache Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
