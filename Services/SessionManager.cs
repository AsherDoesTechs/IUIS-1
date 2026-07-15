using IUIS.Models;

namespace IUIS.Services
{
    public static class SessionManager
    {
        public static User? CurrentUser { get; set; }
        public static bool IsLoggedIn => CurrentUser != null;

        public static void ClearSession()
        {
            CurrentUser = null;
        }
    }
}