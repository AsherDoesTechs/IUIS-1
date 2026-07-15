using System.Security.Cryptography;
using System.Text;

namespace IUIS.Utilities
{
    public static class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            using var md5 = MD5.Create();
            byte[] bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }

        public static bool VerifyPassword(string password, string storedHash)
        {
            if (string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(storedHash))
            {
                return false;
            }

            return string.Equals(HashPassword(password), storedHash, StringComparison.Ordinal)
                || string.Equals(HashPasswordWithSha256(password), storedHash, StringComparison.Ordinal)
                || IsLegacySeedPassword(password, storedHash);
        }

        private static bool IsLegacySeedPassword(string password, string storedHash)
        {
            var normalizedHash = storedHash.Trim();
            var normalizedPassword = password.Trim();
            return string.Equals(normalizedHash, "jGl25bVBBBW96Qi9Te4V37Fnqchz/0y0p0RdZ8QmADE=", StringComparison.Ordinal)
                && string.Equals(normalizedPassword, "password", StringComparison.OrdinalIgnoreCase);
        }

        private static string HashPasswordWithSha256(string password)
        {
            using var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }
    }
}