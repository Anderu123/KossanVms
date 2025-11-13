using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KossanVMS.Data
{
    public enum UserRole
    {
        User = 0,
        Admin = 1
    }
    [Table("vms_users")]
    public class VmsUser :VmsAuditEntity
    {
        [Column("id")]
        public int Id { get;set; }
        [Column("user_name")]
        [Required, MaxLength(50)]
        public string UserName { get; set; }
        [Column("password_hash")]
        
        public byte[]? PasswordHash { get; set; } = Array.Empty<byte>();
        [Column("password_salt")]
   
        public byte[]? PasswordSalt { get; set; } = Array.Empty<byte> ();
        [Column("user_role")]
        [Required]
        public UserRole Role { get; set; } = UserRole.User;
        

    }
    public static class PasswordHelper
    {

        public static void CreatePassworHash(string password, out byte[] hash, out byte[] salt)
        {
            using var hmac = new System.Security.Cryptography.HMACSHA256();
            salt = hmac.Key;
            hash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        }

        public static bool VerifyPassword(string password, byte[] storedHash, byte[] storedSalt)
        {

            using var hmac = new System.Security.Cryptography.HMACSHA256(storedSalt);
            var computed = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            return CryptographicOperations.FixedTimeEquals(computed, storedHash);
        }
    }

    public static class DbSeeder
    {
        public static void EnsureAdmin(VmsContext db)
        {
            var adminName = "Admin";

            var exists = db.VmsUsers
                .Any(u => u.UserName.ToLower() == adminName.ToLower());

            if (!exists)
            {
                PasswordHelper.CreatePassworHash("Kossan@123456", out var hash, out var salt);

                db.VmsUsers.Add(new VmsUser
                {
                    UserName = adminName,
                    PasswordHash = hash,
                    PasswordSalt = salt,
                    Role = UserRole.Admin,   // <-- make it an Admin
                    //IsActive = true          // if you have this column
                });

                db.SaveChanges();
            }
        }
    }


    public static class AppSession
    {
        public static int UserId { get; set; }
        public static string UserName { get; set; }

        public static UserRole Role { get; set; } = UserRole.User;

        public static string BranchName { get; set; }
        public static string DbConnStr { get;set; }
        public static bool IsAuthenticated => UserId > 0;

        public static void SignIn(VmsUser u)
        {
            UserId = u.Id;
            UserName = u.UserName;
            Role = u.Role;
        }

        public static void SignOut(VmsUser u)
        {
            UserId = 0;
            UserName = null;
            Role = UserRole.User;
        }
        public static bool IsAdmin => Role == UserRole.Admin;
    }
}
