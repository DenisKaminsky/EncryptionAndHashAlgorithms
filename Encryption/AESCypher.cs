using System.Security.Cryptography;
using System.Text;

namespace Encryption
{
    public class AESCypher
    {
        public byte[] Encrypt(string input, byte[] key, byte[] iv)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;
                var encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                using (var memoryStream = new MemoryStream())
                {
                    using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (var streamWriter = new StreamWriter(cryptoStream))
                        {
                            streamWriter.Write(input);
                        }

                        return memoryStream.ToArray();
                    }
                }
            }
        }

        public byte[] Decrypt(byte[] encryptedText, byte[] key, byte[] iv)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;
                var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                using (var memoryStream = new MemoryStream(encryptedText))
                {
                    using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        var decryptedBytes = new byte[encryptedText.Length];
                        cryptoStream.Read(decryptedBytes, 0, decryptedBytes.Length);
                        return decryptedBytes;
                    }
                }
            }
        }
    }
}
