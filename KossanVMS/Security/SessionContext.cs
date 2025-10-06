using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace KossanVMS.Security // Put it in a security-related namespace
    {
        public static class SessionContext
        {
            // Must match the enum you defined for your roles
            public enum UserRole
            {
                SuperAdmin = 1,
                Safety = 2,
                Shipping = 3,
                PolisBantuan = 4
            }

            public static int UserID { get; private set; }
            public static UserRole CurrentUserRole { get; private set; }
            public static bool IsLoggedIn { get; private set; }

            public static void SetUser(int userId, UserRole roleId)
            {
                UserID = userId;
                CurrentUserRole = (UserRole)roleId;
                IsLoggedIn = true;
            }

            // Helper methods for easy RBAC checks
            public static bool IsSuperAdmin() => CurrentUserRole == UserRole.SuperAdmin;

            public static bool HasRole(UserRole role) => CurrentUserRole == role || IsSuperAdmin();
        }
    }

