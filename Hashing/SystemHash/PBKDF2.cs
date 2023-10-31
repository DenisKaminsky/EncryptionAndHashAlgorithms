using System.Security.Cryptography;
using System.Text;

namespace Hashing.SystemHash
{
    public class PBKDF2
    {
        private const int DEFAULT_SALT_SIZE = 32;
        private const int DEFAULT_HASH_SIZE = 32;
        private const int DEFAULT_ITERATIONS = 10000;

        private HashAlgorithmName _hashAlgorithm;

        public PBKDF2(HashAlgorithmName hashAlgorithm)
        {
            _hashAlgorithm = hashAlgorithm;            
        }

        public (string hash, string salt) CalculateHash(string password)
        {
            using (var rng = RandomNumberGenerator.Create())
            {
                //generate random salt
                var salt = new byte[DEFAULT_SALT_SIZE];
                rng.GetBytes(salt);

                //hash password
                var hash = Pbkdf2(password, salt, DEFAULT_ITERATIONS, DEFAULT_HASH_SIZE);

                return (Convert.ToHexString(hash), Convert.ToHexString(salt));
            }
        }

        public string CalculateHash(string password, string salt)
        {
            var hash = Pbkdf2(password, Encoding.UTF8.GetBytes(salt), DEFAULT_ITERATIONS, DEFAULT_HASH_SIZE);
            return Convert.ToHexString(hash);
        }

        public bool ValidatePassword(string password, string salt, string targetHash)
        {
            var actualHash = Pbkdf2(password, Encoding.UTF8.GetBytes(salt), DEFAULT_ITERATIONS, DEFAULT_HASH_SIZE);
            return Convert.ToHexString(actualHash).Equals(targetHash, StringComparison.OrdinalIgnoreCase);
        }

        private byte[] Pbkdf2(string password, byte[] salt, int iterations, int outputBytes)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations, _hashAlgorithm))
            {
                return pbkdf2.GetBytes(outputBytes);
            }
        }
    }
}
