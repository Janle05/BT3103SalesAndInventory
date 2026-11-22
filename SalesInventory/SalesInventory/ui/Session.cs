using SalesInventory.businesslogic;

namespace SalesInventory.ui
{
    
    public static class Session
    {
        public static User? CurrentUser { get; set; }

        public static int UserId
        {
            get { return CurrentUser?.UserID ?? 0; }
        }

        public static void Clear()
        {
            CurrentUser = null;
        }
    }
}
