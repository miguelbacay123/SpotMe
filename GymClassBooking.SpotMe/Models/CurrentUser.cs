using GymClassBooking.SpotMe.Models;
using GymClassBooking.SpotMe.Controllers;

namespace GymClassBooking.SpotMe.Controllers
{
    public static class CurrentUser
    {
        public static User User { get; set; }
        public static string UserRole { get; set; }
        public static string UserEmail { get; set; }

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

        public static bool IsSuperAdmin()
        {
            return UserRole == "SuperAdmin";
        }

        public static bool IsStaff()
        {
            return UserRole == "Staff";
        }

        public static bool IsMember()
        {
            return UserRole == "Member";
        }

        public static bool CanManageStaff()
        {
            return IsSuperAdmin();
        }

        public static bool CanEditDonations()
        {
            return IsSuperAdmin();
        }

        public static bool CanManageMember(string memberEmail)
        {
            if (IsSuperAdmin() || IsStaff())
                return true;

            if (IsMember())
                return UserEmail == memberEmail;

            return false;
        }

        public static bool CanViewMemberDetails(string memberEmail)
        {
            if (IsSuperAdmin() || IsStaff())
                return true;

            if (IsMember())
                return UserEmail == memberEmail;

            return false;
        }

        public static void Logout()
        {
            User = null;
            UserRole = null;
            UserEmail = null;
        }
    }
}