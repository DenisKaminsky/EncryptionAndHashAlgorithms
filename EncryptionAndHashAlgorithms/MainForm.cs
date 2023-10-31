using Encryption;
using Hashing;
using Hashing.SystemHash;
using System.Security.Cryptography;
using System.Text;

namespace EncryptionAndHashAlgorithms
{
    public partial class MainForm : Form
    {
        private IHashProvider? _systemMd5 { get; set; }
        private IHashProvider SystemMd5
        {
            get
            {
                _systemMd5 ??= new Hashing.SystemHash.MD5HashProvider();
                return _systemMd5;
            }
        }

        private IHashProvider? _systemSha256 { get; set; }
        private IHashProvider SystemSha256
        {
            get
            {
                _systemSha256 ??= new Hashing.SystemHash.Sha256HashProvider();
                return _systemSha256;
            }
        }

        private IHashProvider? _systemSha512 { get; set; }
        private IHashProvider SystemSha512
        {
            get
            {
                _systemSha512 ??= new Hashing.SystemHash.Sha512HashProvider();
                return _systemSha512;
            }
        }

        private PBKDF2 _pbkf2_sha256 { get; set; }
        private PBKDF2 PBKDF2_Sha256
        {
            get
            {
                _pbkf2_sha256 ??= new PBKDF2(HashAlgorithmName.SHA256);
                return _pbkf2_sha256;
            }
        }

        private RSACypher _rsaCypher { get; set; }
        private RSACypher RSACypher
        {
            get
            {
                _rsaCypher ??= new RSACypher();
                return _rsaCypher;
            }
        }

        private AESCypher _aesCypher { get; set; }
        private AESCypher AESCypher
        {
            get
            {
                _aesCypher ??= new AESCypher();
                return _aesCypher;
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void InputSystemHash_TextChanged(object sender, EventArgs e)
        {
            CalculateSystemHashButton.Enabled = InputSystemHash.Text.Trim().Length > 0;
        }

        private void RSAInput_TextChanged(object sender, EventArgs e)
        {
            var enabled = RSAInput.Text.Trim().Length > 0;
            RSAEncryptButton.Enabled = RSADecryptButton.Enabled = enabled;
        }

        private void AESInput_TextChanged(object sender, EventArgs e)
        {
            var enabled = AESInput.Text.Trim().Length > 0;
            AESEncryptButton.Enabled = AESDecryptButton.Enabled = enabled;
        }

        private void CopySystemHash_Click(object sender, EventArgs e)
        {
            if (OutputSystemHash.Text?.Any() ?? false)
            {
                Clipboard.SetText(OutputSystemHash.Text);
            }
        }

        private void RSAOutputCopy_Click(object sender, EventArgs e)
        {
            if (RSAOutput.Text?.Any() ?? false)
            {
                Clipboard.SetText(RSAOutput.Text);
            }
        }

        private void AESCopyOutputButton_Click(object sender, EventArgs e)
        {
            if (AESOutput.Text?.Any() ?? false)
            {
                Clipboard.SetText(AESOutput.Text);
            }
        }

        private void CalculateSystemHashButton_Click(object sender, EventArgs e)
        {
            var input = InputSystemHash.Text.Trim();
            var output = string.Empty;

            if (MD5Option.Checked)
            {
                output = SystemMd5.CalculateHash(input);
            }
            else if (SHA256Option.Checked)
            {
                output = SystemSha256.CalculateHash(input);
            }
            else if (Sha512Option.Checked)
            {
                output = SystemSha512.CalculateHash(input);
            }
            else if (PBKDF2HashOption.Checked)
            {
                output = PBKDF2_Sha256.CalculateHash(InputSystemHash.Text, "test");
            }

            OutputSystemHash.Text = output;
            OutputSystemHash.SelectAll();
            OutputSystemHash.Focus();
        }

        private void GenerateRSAKeys_Click(object sender, EventArgs e)
        {
            var (PublicKey, PrivateKey) = RSACypher.GenerateKeys(1024);
            RSAPublicKeyInput.Text = Convert.ToBase64String(PublicKey);
            RSAPrivateKeyInput.Text = Convert.ToBase64String(PrivateKey);
        }

        private void RSAEncryptButton_Click(object sender, EventArgs e)
        {
            var output = RSACypher.Encrypt(RSAInput.Text.Trim(), Convert.FromBase64String(RSAPublicKeyInput.Text.Trim()));
            RSAOutput.Text = Convert.ToBase64String(output);
            RSAOutput.SelectAll();
            RSAOutput.Focus();
        }

        private void RSADecryptButton_Click(object sender, EventArgs e)
        {
            var output = RSACypher.Decrypt(Convert.FromBase64String(RSAInput.Text.Trim()), Convert.FromBase64String(RSAPrivateKeyInput.Text.Trim()));
            RSAOutput.Text = Encoding.UTF8.GetString(output);
            RSAOutput.SelectAll();
            RSAOutput.Focus();
        }

        private void AESEncryptButton_Click(object sender, EventArgs e)
        {
            var key = Encoding.UTF8.GetBytes(AESKeyInput.Text.Trim());
            var initVector = Encoding.UTF8.GetBytes(AESVectorInput.Text.Trim());
            var output = AESCypher.Encrypt(AESInput.Text.Trim(), key, initVector);

            AESOutput.Text = Convert.ToBase64String(output);
            AESOutput.SelectAll();
            AESOutput.Focus();
        }

        private void AESDecryptButton_Click(object sender, EventArgs e)
        {
            var key = Encoding.UTF8.GetBytes(AESKeyInput.Text.Trim());
            var initVector = Encoding.UTF8.GetBytes(AESVectorInput.Text.Trim());

            var output = AESCypher.Decrypt(Convert.FromBase64String(AESInput.Text.Trim()), key, initVector);
            AESOutput.Text = Encoding.UTF8.GetString(output);
            AESOutput.SelectAll();
            AESOutput.Focus();
        }
    }
}