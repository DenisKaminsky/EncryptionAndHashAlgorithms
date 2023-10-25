using System.Security.Cryptography;
using System.Text;

namespace Hashing.SystemHash
{
    public class MD5HashProvider : IHashProvider
    {
        public string CalculateHash(string input)
        {
            using (var md5 = MD5.Create())
            {
                var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
                return Convert.ToHexString(hash);
            }
        }
    }
}
