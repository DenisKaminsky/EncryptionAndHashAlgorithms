using System.Security.Cryptography;
using System.Text;

namespace Hashing.SystemHash
{
    public class Sha256HashProvider : IHashProvider
    {
        public string CalculateHash(string input)
        {
            using (var sha256 = SHA256.Create())
            {
                var hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                return Convert.ToHexString(hash);
            }
        }
    }
}
