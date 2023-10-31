namespace EncryptionAndHashAlgorithms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainTabControl = new TabControl();
            HashTabPanel = new TabPage();
            HashTypeTabControl = new TabControl();
            SystemHashTypeTab = new TabPage();
            PBKDF2HashOption = new RadioButton();
            CopySystemHash = new Button();
            OutputSystemHash = new TextBox();
            InputSystemHash = new TextBox();
            label2 = new Label();
            Sha512Option = new RadioButton();
            SHA256Option = new RadioButton();
            MD5Option = new RadioButton();
            CalculateSystemHashButton = new Button();
            label1 = new Label();
            EncryptionTabPanel = new TabPage();
            EctyptionTypeTabControl = new TabControl();
            RSAOption = new TabPage();
            RSAOutputCopy = new Button();
            label5 = new Label();
            RSAEncryptButton = new Button();
            RSAOutput = new TextBox();
            InputRSA = new Label();
            label4 = new Label();
            label3 = new Label();
            RSADecryptButton = new Button();
            GenerateRSAKeys = new Button();
            RSAInput = new TextBox();
            RSAPrivateKeyInput = new TextBox();
            RSAPublicKeyInput = new TextBox();
            AesTabPage = new TabPage();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            AESVectorInput = new TextBox();
            AESKeyInput = new TextBox();
            AESOutput = new TextBox();
            AESInput = new TextBox();
            AESCopyOutputButton = new Button();
            AESDecryptButton = new Button();
            AESEncryptButton = new Button();
            MainTabControl.SuspendLayout();
            HashTabPanel.SuspendLayout();
            HashTypeTabControl.SuspendLayout();
            SystemHashTypeTab.SuspendLayout();
            EncryptionTabPanel.SuspendLayout();
            EctyptionTypeTabControl.SuspendLayout();
            RSAOption.SuspendLayout();
            AesTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(HashTabPanel);
            MainTabControl.Controls.Add(EncryptionTabPanel);
            MainTabControl.Location = new Point(12, 12);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(520, 340);
            MainTabControl.TabIndex = 0;
            // 
            // HashTabPanel
            // 
            HashTabPanel.BackColor = Color.LightSteelBlue;
            HashTabPanel.Controls.Add(HashTypeTabControl);
            HashTabPanel.Location = new Point(4, 26);
            HashTabPanel.Name = "HashTabPanel";
            HashTabPanel.Padding = new Padding(3);
            HashTabPanel.Size = new Size(512, 310);
            HashTabPanel.TabIndex = 0;
            HashTabPanel.Text = "Hash";
            // 
            // HashTypeTabControl
            // 
            HashTypeTabControl.Controls.Add(SystemHashTypeTab);
            HashTypeTabControl.Location = new Point(6, 4);
            HashTypeTabControl.Name = "HashTypeTabControl";
            HashTypeTabControl.SelectedIndex = 0;
            HashTypeTabControl.Size = new Size(500, 300);
            HashTypeTabControl.TabIndex = 1;
            // 
            // SystemHashTypeTab
            // 
            SystemHashTypeTab.Controls.Add(PBKDF2HashOption);
            SystemHashTypeTab.Controls.Add(CopySystemHash);
            SystemHashTypeTab.Controls.Add(OutputSystemHash);
            SystemHashTypeTab.Controls.Add(InputSystemHash);
            SystemHashTypeTab.Controls.Add(label2);
            SystemHashTypeTab.Controls.Add(Sha512Option);
            SystemHashTypeTab.Controls.Add(SHA256Option);
            SystemHashTypeTab.Controls.Add(MD5Option);
            SystemHashTypeTab.Controls.Add(CalculateSystemHashButton);
            SystemHashTypeTab.Controls.Add(label1);
            SystemHashTypeTab.Location = new Point(4, 26);
            SystemHashTypeTab.Name = "SystemHashTypeTab";
            SystemHashTypeTab.Padding = new Padding(3);
            SystemHashTypeTab.Size = new Size(492, 270);
            SystemHashTypeTab.TabIndex = 0;
            SystemHashTypeTab.Text = "System";
            SystemHashTypeTab.UseVisualStyleBackColor = true;
            // 
            // PBKDF2HashOption
            // 
            PBKDF2HashOption.AutoSize = true;
            PBKDF2HashOption.Location = new Point(350, 60);
            PBKDF2HashOption.Name = "PBKDF2HashOption";
            PBKDF2HashOption.Size = new Size(127, 21);
            PBKDF2HashOption.TabIndex = 10;
            PBKDF2HashOption.TabStop = true;
            PBKDF2HashOption.Text = "PBKDF2 (SHA256)";
            PBKDF2HashOption.UseVisualStyleBackColor = true;
            // 
            // CopySystemHash
            // 
            CopySystemHash.BackColor = Color.LightSteelBlue;
            CopySystemHash.Location = new Point(49, 224);
            CopySystemHash.Name = "CopySystemHash";
            CopySystemHash.Size = new Size(429, 30);
            CopySystemHash.TabIndex = 9;
            CopySystemHash.Text = "Copy to clipboard";
            CopySystemHash.UseVisualStyleBackColor = false;
            CopySystemHash.Click += CopySystemHash_Click;
            // 
            // OutputSystemHash
            // 
            OutputSystemHash.BorderStyle = BorderStyle.FixedSingle;
            OutputSystemHash.Location = new Point(49, 158);
            OutputSystemHash.Multiline = true;
            OutputSystemHash.Name = "OutputSystemHash";
            OutputSystemHash.ReadOnly = true;
            OutputSystemHash.Size = new Size(429, 60);
            OutputSystemHash.TabIndex = 8;
            OutputSystemHash.TextAlign = HorizontalAlignment.Center;
            // 
            // InputSystemHash
            // 
            InputSystemHash.BorderStyle = BorderStyle.FixedSingle;
            InputSystemHash.Location = new Point(49, 22);
            InputSystemHash.Name = "InputSystemHash";
            InputSystemHash.Size = new Size(429, 25);
            InputSystemHash.TabIndex = 0;
            InputSystemHash.TextAlign = HorizontalAlignment.Center;
            InputSystemHash.TextChanged += InputSystemHash_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 178);
            label2.Name = "label2";
            label2.Size = new Size(48, 17);
            label2.TabIndex = 7;
            label2.Text = "Output";
            // 
            // Sha512Option
            // 
            Sha512Option.AutoSize = true;
            Sha512Option.Location = new Point(254, 60);
            Sha512Option.Name = "Sha512Option";
            Sha512Option.Size = new Size(75, 21);
            Sha512Option.TabIndex = 6;
            Sha512Option.Text = "SHA 512";
            Sha512Option.UseVisualStyleBackColor = true;
            // 
            // SHA256Option
            // 
            SHA256Option.AutoSize = true;
            SHA256Option.Location = new Point(146, 60);
            SHA256Option.Name = "SHA256Option";
            SHA256Option.Size = new Size(75, 21);
            SHA256Option.TabIndex = 5;
            SHA256Option.Text = "SHA 256";
            SHA256Option.UseVisualStyleBackColor = true;
            // 
            // MD5Option
            // 
            MD5Option.AutoSize = true;
            MD5Option.Checked = true;
            MD5Option.Location = new Point(59, 60);
            MD5Option.Name = "MD5Option";
            MD5Option.Size = new Size(54, 21);
            MD5Option.TabIndex = 4;
            MD5Option.TabStop = true;
            MD5Option.Text = "MD5";
            MD5Option.UseVisualStyleBackColor = true;
            // 
            // CalculateSystemHashButton
            // 
            CalculateSystemHashButton.BackColor = Color.Salmon;
            CalculateSystemHashButton.Enabled = false;
            CalculateSystemHashButton.Location = new Point(49, 103);
            CalculateSystemHashButton.Name = "CalculateSystemHashButton";
            CalculateSystemHashButton.Size = new Size(429, 35);
            CalculateSystemHashButton.TabIndex = 3;
            CalculateSystemHashButton.Text = "Calculate";
            CalculateSystemHashButton.UseVisualStyleBackColor = false;
            CalculateSystemHashButton.Click += CalculateSystemHashButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 24);
            label1.Name = "label1";
            label1.Size = new Size(37, 17);
            label1.TabIndex = 1;
            label1.Text = "Input";
            // 
            // EncryptionTabPanel
            // 
            EncryptionTabPanel.BackColor = Color.LightSteelBlue;
            EncryptionTabPanel.Controls.Add(EctyptionTypeTabControl);
            EncryptionTabPanel.Location = new Point(4, 26);
            EncryptionTabPanel.Name = "EncryptionTabPanel";
            EncryptionTabPanel.Padding = new Padding(3);
            EncryptionTabPanel.Size = new Size(512, 310);
            EncryptionTabPanel.TabIndex = 1;
            EncryptionTabPanel.Text = "Encryption";
            // 
            // EctyptionTypeTabControl
            // 
            EctyptionTypeTabControl.Controls.Add(RSAOption);
            EctyptionTypeTabControl.Controls.Add(AesTabPage);
            EctyptionTypeTabControl.Location = new Point(6, 6);
            EctyptionTypeTabControl.Name = "EctyptionTypeTabControl";
            EctyptionTypeTabControl.SelectedIndex = 0;
            EctyptionTypeTabControl.Size = new Size(500, 301);
            EctyptionTypeTabControl.TabIndex = 0;
            // 
            // RSAOption
            // 
            RSAOption.Controls.Add(RSAOutputCopy);
            RSAOption.Controls.Add(label5);
            RSAOption.Controls.Add(RSAEncryptButton);
            RSAOption.Controls.Add(RSAOutput);
            RSAOption.Controls.Add(InputRSA);
            RSAOption.Controls.Add(label4);
            RSAOption.Controls.Add(label3);
            RSAOption.Controls.Add(RSADecryptButton);
            RSAOption.Controls.Add(GenerateRSAKeys);
            RSAOption.Controls.Add(RSAInput);
            RSAOption.Controls.Add(RSAPrivateKeyInput);
            RSAOption.Controls.Add(RSAPublicKeyInput);
            RSAOption.Location = new Point(4, 26);
            RSAOption.Name = "RSAOption";
            RSAOption.Padding = new Padding(3);
            RSAOption.Size = new Size(492, 271);
            RSAOption.TabIndex = 0;
            RSAOption.Text = "RSA";
            RSAOption.UseVisualStyleBackColor = true;
            // 
            // RSAOutputCopy
            // 
            RSAOutputCopy.BackColor = Color.LightSteelBlue;
            RSAOutputCopy.Location = new Point(85, 236);
            RSAOutputCopy.Name = "RSAOutputCopy";
            RSAOutputCopy.Size = new Size(401, 29);
            RSAOutputCopy.TabIndex = 11;
            RSAOutputCopy.Text = "Copy to clipboard";
            RSAOutputCopy.UseVisualStyleBackColor = false;
            RSAOutputCopy.Click += RSAOutputCopy_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 209);
            label5.Name = "label5";
            label5.Size = new Size(48, 17);
            label5.TabIndex = 10;
            label5.Text = "Output";
            // 
            // RSAEncryptButton
            // 
            RSAEncryptButton.Enabled = false;
            RSAEncryptButton.Location = new Point(85, 147);
            RSAEncryptButton.Name = "RSAEncryptButton";
            RSAEncryptButton.Size = new Size(199, 32);
            RSAEncryptButton.TabIndex = 9;
            RSAEncryptButton.Text = "Encrypt";
            RSAEncryptButton.UseVisualStyleBackColor = true;
            RSAEncryptButton.Click += RSAEncryptButton_Click;
            // 
            // RSAOutput
            // 
            RSAOutput.BorderStyle = BorderStyle.FixedSingle;
            RSAOutput.Enabled = false;
            RSAOutput.Location = new Point(85, 205);
            RSAOutput.Name = "RSAOutput";
            RSAOutput.ReadOnly = true;
            RSAOutput.Size = new Size(401, 25);
            RSAOutput.TabIndex = 8;
            // 
            // InputRSA
            // 
            InputRSA.AutoSize = true;
            InputRSA.Location = new Point(41, 117);
            InputRSA.Name = "InputRSA";
            InputRSA.Size = new Size(37, 17);
            InputRSA.TabIndex = 7;
            InputRSA.Text = "Input";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 34);
            label4.Name = "label4";
            label4.Size = new Size(72, 17);
            label4.TabIndex = 6;
            label4.Text = "Private Key";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 10);
            label3.Name = "label3";
            label3.Size = new Size(67, 17);
            label3.TabIndex = 5;
            label3.Text = "Public Key";
            // 
            // RSADecryptButton
            // 
            RSADecryptButton.Enabled = false;
            RSADecryptButton.Location = new Point(290, 147);
            RSADecryptButton.Name = "RSADecryptButton";
            RSADecryptButton.Size = new Size(196, 32);
            RSADecryptButton.TabIndex = 4;
            RSADecryptButton.Text = "Decrypt";
            RSADecryptButton.UseVisualStyleBackColor = true;
            RSADecryptButton.Click += RSADecryptButton_Click;
            // 
            // GenerateRSAKeys
            // 
            GenerateRSAKeys.BackColor = Color.Salmon;
            GenerateRSAKeys.Location = new Point(85, 65);
            GenerateRSAKeys.Name = "GenerateRSAKeys";
            GenerateRSAKeys.Size = new Size(401, 30);
            GenerateRSAKeys.TabIndex = 3;
            GenerateRSAKeys.Text = "Generate Keys";
            GenerateRSAKeys.UseVisualStyleBackColor = false;
            GenerateRSAKeys.Click += GenerateRSAKeys_Click;
            // 
            // RSAInput
            // 
            RSAInput.BorderStyle = BorderStyle.FixedSingle;
            RSAInput.Location = new Point(85, 116);
            RSAInput.Name = "RSAInput";
            RSAInput.Size = new Size(401, 25);
            RSAInput.TabIndex = 2;
            RSAInput.TextChanged += RSAInput_TextChanged;
            // 
            // RSAPrivateKeyInput
            // 
            RSAPrivateKeyInput.BorderStyle = BorderStyle.FixedSingle;
            RSAPrivateKeyInput.Location = new Point(85, 34);
            RSAPrivateKeyInput.Name = "RSAPrivateKeyInput";
            RSAPrivateKeyInput.Size = new Size(401, 25);
            RSAPrivateKeyInput.TabIndex = 1;
            // 
            // RSAPublicKeyInput
            // 
            RSAPublicKeyInput.BorderStyle = BorderStyle.FixedSingle;
            RSAPublicKeyInput.Location = new Point(85, 7);
            RSAPublicKeyInput.Name = "RSAPublicKeyInput";
            RSAPublicKeyInput.Size = new Size(401, 25);
            RSAPublicKeyInput.TabIndex = 0;
            // 
            // AesTabPage
            // 
            AesTabPage.Controls.Add(label9);
            AesTabPage.Controls.Add(label8);
            AesTabPage.Controls.Add(label7);
            AesTabPage.Controls.Add(label6);
            AesTabPage.Controls.Add(AESVectorInput);
            AesTabPage.Controls.Add(AESKeyInput);
            AesTabPage.Controls.Add(AESOutput);
            AesTabPage.Controls.Add(AESInput);
            AesTabPage.Controls.Add(AESCopyOutputButton);
            AesTabPage.Controls.Add(AESDecryptButton);
            AesTabPage.Controls.Add(AESEncryptButton);
            AesTabPage.Location = new Point(4, 26);
            AesTabPage.Name = "AesTabPage";
            AesTabPage.Padding = new Padding(3);
            AesTabPage.Size = new Size(492, 271);
            AesTabPage.TabIndex = 1;
            AesTabPage.Text = "AES(CBC - 128)";
            AesTabPage.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(45, 18);
            label9.Name = "label9";
            label9.Size = new Size(29, 17);
            label9.TabIndex = 10;
            label9.Text = "Key";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 50);
            label8.Name = "label8";
            label8.Size = new Size(68, 17);
            label8.TabIndex = 9;
            label8.Text = "Init. vector";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 184);
            label7.Name = "label7";
            label7.Size = new Size(48, 17);
            label7.TabIndex = 8;
            label7.Text = "Output";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 109);
            label6.Name = "label6";
            label6.Size = new Size(37, 17);
            label6.TabIndex = 7;
            label6.Text = "Input";
            // 
            // AESVectorInput
            // 
            AESVectorInput.BorderStyle = BorderStyle.FixedSingle;
            AESVectorInput.Location = new Point(80, 47);
            AESVectorInput.MaxLength = 16;
            AESVectorInput.Name = "AESVectorInput";
            AESVectorInput.Size = new Size(388, 25);
            AESVectorInput.TabIndex = 6;
            // 
            // AESKeyInput
            // 
            AESKeyInput.BorderStyle = BorderStyle.FixedSingle;
            AESKeyInput.Location = new Point(80, 16);
            AESKeyInput.MaxLength = 16;
            AESKeyInput.Name = "AESKeyInput";
            AESKeyInput.Size = new Size(388, 25);
            AESKeyInput.TabIndex = 5;
            // 
            // AESOutput
            // 
            AESOutput.BorderStyle = BorderStyle.FixedSingle;
            AESOutput.Enabled = false;
            AESOutput.Location = new Point(80, 182);
            AESOutput.Name = "AESOutput";
            AESOutput.ReadOnly = true;
            AESOutput.Size = new Size(388, 25);
            AESOutput.TabIndex = 4;
            // 
            // AESInput
            // 
            AESInput.BorderStyle = BorderStyle.FixedSingle;
            AESInput.Location = new Point(80, 106);
            AESInput.MaxLength = 300;
            AESInput.Name = "AESInput";
            AESInput.Size = new Size(388, 25);
            AESInput.TabIndex = 3;
            AESInput.TextChanged += AESInput_TextChanged;
            // 
            // AESCopyOutputButton
            // 
            AESCopyOutputButton.BackColor = Color.LightSteelBlue;
            AESCopyOutputButton.Location = new Point(80, 213);
            AESCopyOutputButton.Name = "AESCopyOutputButton";
            AESCopyOutputButton.Size = new Size(388, 30);
            AESCopyOutputButton.TabIndex = 2;
            AESCopyOutputButton.Text = "Copy to clipboard";
            AESCopyOutputButton.UseVisualStyleBackColor = false;
            AESCopyOutputButton.Click += AESCopyOutputButton_Click;
            // 
            // AESDecryptButton
            // 
            AESDecryptButton.Enabled = false;
            AESDecryptButton.Location = new Point(286, 137);
            AESDecryptButton.Name = "AESDecryptButton";
            AESDecryptButton.Size = new Size(182, 32);
            AESDecryptButton.TabIndex = 1;
            AESDecryptButton.Text = "Decrypt";
            AESDecryptButton.UseVisualStyleBackColor = true;
            AESDecryptButton.Click += AESDecryptButton_Click;
            // 
            // AESEncryptButton
            // 
            AESEncryptButton.Enabled = false;
            AESEncryptButton.Location = new Point(80, 137);
            AESEncryptButton.Name = "AESEncryptButton";
            AESEncryptButton.Size = new Size(200, 32);
            AESEncryptButton.TabIndex = 0;
            AESEncryptButton.Text = "Encrypt";
            AESEncryptButton.UseVisualStyleBackColor = true;
            AESEncryptButton.Click += AESEncryptButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(536, 359);
            Controls.Add(MainTabControl);
            Name = "MainForm";
            Text = "MainForm";
            MainTabControl.ResumeLayout(false);
            HashTabPanel.ResumeLayout(false);
            HashTypeTabControl.ResumeLayout(false);
            SystemHashTypeTab.ResumeLayout(false);
            SystemHashTypeTab.PerformLayout();
            EncryptionTabPanel.ResumeLayout(false);
            EctyptionTypeTabControl.ResumeLayout(false);
            RSAOption.ResumeLayout(false);
            RSAOption.PerformLayout();
            AesTabPage.ResumeLayout(false);
            AesTabPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl MainTabControl;
        private TabPage HashTabPanel;
        private TabPage EncryptionTabPanel;
        private TabControl HashTypeTabControl;
        private TabPage SystemHashTypeTab;
        private Button CopySystemHash;
        private TextBox OutputSystemHash;
        private TextBox InputSystemHash;
        private Label label2;
        private RadioButton Sha512Option;
        private RadioButton SHA256Option;
        private RadioButton MD5Option;
        private Button CalculateSystemHashButton;
        private Label label1;
        private RadioButton PBKDF2HashOption;
        private TabControl EctyptionTypeTabControl;
        private TabPage RSAOption;
        private TabPage AesTabPage;
        private TextBox RSAInput;
        private TextBox RSAPrivateKeyInput;
        private TextBox RSAPublicKeyInput;
        private Label label4;
        private Label label3;
        private Button RSADecryptButton;
        private Button GenerateRSAKeys;
        private Label InputRSA;
        private Label label5;
        private Button RSAEncryptButton;
        private TextBox RSAOutput;
        private Button RSAOutputCopy;
        private Button AESCopyOutputButton;
        private Button AESDecryptButton;
        private Button AESEncryptButton;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox AESVectorInput;
        private TextBox AESKeyInput;
        private TextBox AESOutput;
        private TextBox AESInput;
    }
}