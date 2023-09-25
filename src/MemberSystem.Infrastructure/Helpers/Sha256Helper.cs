using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace MemberSystem.Infrastructure.Helpers
{
    public class Sha256Helper
    {
        public static string ComputeSHA256(string s)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashValue = sha256.ComputeHash(Encoding.UTF8.GetBytes(s));
                return Convert.ToHexString(hashValue);
            }
        }
    }
}
