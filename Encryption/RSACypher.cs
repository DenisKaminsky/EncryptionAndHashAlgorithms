using System.Security.Cryptography;
using System.Text;

namespace Encryption
{
    public class RSACypher
    {
        public byte[] Encrypt(string input, byte[] publicKey)
        {
            using (var rsaCryptoServiceProvider = new RSACryptoServiceProvider())
            {
                rsaCryptoServiceProvider.ImportRSAPublicKey(publicKey, out var bytesRead);
                var byteData = Encoding.UTF8.GetBytes(input);
                return rsaCryptoServiceProvider.Encrypt(byteData, false);
            }
        }

        public byte[] Decrypt(byte[] encryptedText, byte[] privateKey)
        {
            using (var rsaCryptoServiceProvider = new RSACryptoServiceProvider())
            {
                rsaCryptoServiceProvider.ImportRSAPrivateKey(privateKey, out var bytesRead);
                return rsaCryptoServiceProvider.Decrypt(encryptedText, false);
            }
        }

        public (byte[] PublicKey, byte[] PrivateKey) GenerateKeys(int size)
        {
            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                var publicKey = rsa.ExportRSAPublicKey();
                var privateKey = rsa.ExportRSAPrivateKey();

                return (publicKey, privateKey);
            };
        }
    }
}