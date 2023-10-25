using System.Security.Cryptography;
using System.Text;

namespace Hashing.SystemHash
{
    public class Sha512HashProvider : IHashProvider
    {
        public string CalculateHash(string input)
        {
            using (var sha512 = SHA512.Create())
            {
                var hash = sha512.ComputeHash(Encoding.UTF8.GetBytes(input));
                return Convert.ToHexString(hash);
            }
        }
    }
}
