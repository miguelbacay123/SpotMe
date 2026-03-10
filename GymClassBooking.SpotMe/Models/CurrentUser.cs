using GymClassBooking.SpotMe.Models;

namespace GymClassBooking.SpotMe.Controllers
{
    public static class CurrentUser
    {
        public static User User { get; set; }

        public static int? UserId
        {
            get { return User?.Id; }
        }

        public static string UserName
        {
            get { return User?.FullName ?? "System"; }
        }

        public static bool IsLoggedIn
        {
            get { return User != null; }
        }

        public static void Logout()
        {
            User = null;
        }
    }
}