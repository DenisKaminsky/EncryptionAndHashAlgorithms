using Hashing;

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

        public MainForm()
        {
            InitializeComponent();
        }

        private void InputSystemHash_TextChanged(object sender, EventArgs e)
        {
            CalculateSystemHashButton.Enabled = InputSystemHash.Text.Trim().Length > 0;
        }

        private void CopySystemHash_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(OutputSystemHash.Text);
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

            OutputSystemHash.Text = output;
            OutputSystemHash.SelectAll();
            OutputSystemHash.Focus();
        }
    }
}