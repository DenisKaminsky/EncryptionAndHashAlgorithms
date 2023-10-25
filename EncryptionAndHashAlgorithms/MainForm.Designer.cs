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
            CopySystemHash = new Button();
            OutputSystemHash = new TextBox();
            label2 = new Label();
            Sha512Option = new RadioButton();
            SHA256Option = new RadioButton();
            MD5Option = new RadioButton();
            CalculateSystemHashButton = new Button();
            label1 = new Label();
            InputSystemHash = new TextBox();
            CustomHashTypeTab = new TabPage();
            EncryptionTabPanel = new TabPage();
            MainTabControl.SuspendLayout();
            HashTabPanel.SuspendLayout();
            HashTypeTabControl.SuspendLayout();
            SystemHashTypeTab.SuspendLayout();
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
            HashTypeTabControl.Controls.Add(CustomHashTypeTab);
            HashTypeTabControl.Location = new Point(6, 4);
            HashTypeTabControl.Name = "HashTypeTabControl";
            HashTypeTabControl.SelectedIndex = 0;
            HashTypeTabControl.Size = new Size(500, 300);
            HashTypeTabControl.TabIndex = 1;
            // 
            // SystemHashTypeTab
            // 
            SystemHashTypeTab.Controls.Add(CopySystemHash);
            SystemHashTypeTab.Controls.Add(OutputSystemHash);
            SystemHashTypeTab.Controls.Add(label2);
            SystemHashTypeTab.Controls.Add(Sha512Option);
            SystemHashTypeTab.Controls.Add(SHA256Option);
            SystemHashTypeTab.Controls.Add(MD5Option);
            SystemHashTypeTab.Controls.Add(CalculateSystemHashButton);
            SystemHashTypeTab.Controls.Add(label1);
            SystemHashTypeTab.Controls.Add(InputSystemHash);
            SystemHashTypeTab.Location = new Point(4, 26);
            SystemHashTypeTab.Name = "SystemHashTypeTab";
            SystemHashTypeTab.Padding = new Padding(3);
            SystemHashTypeTab.Size = new Size(492, 270);
            SystemHashTypeTab.TabIndex = 0;
            SystemHashTypeTab.Text = "System";
            SystemHashTypeTab.UseVisualStyleBackColor = true;
            // 
            // CopySystemHash
            // 
            CopySystemHash.BackColor = Color.LightSteelBlue;
            CopySystemHash.Location = new Point(49, 189);
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
            OutputSystemHash.Name = "OutputSystemHash";
            OutputSystemHash.ReadOnly = true;
            OutputSystemHash.Size = new Size(429, 25);
            OutputSystemHash.TabIndex = 8;
            OutputSystemHash.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 162);
            label2.Name = "label2";
            label2.Size = new Size(48, 17);
            label2.TabIndex = 7;
            label2.Text = "Output";
            // 
            // Sha512Option
            // 
            Sha512Option.AutoSize = true;
            Sha512Option.Location = new Point(367, 60);
            Sha512Option.Name = "Sha512Option";
            Sha512Option.Size = new Size(75, 21);
            Sha512Option.TabIndex = 6;
            Sha512Option.Text = "SHA 512";
            Sha512Option.UseVisualStyleBackColor = true;
            // 
            // SHA256Option
            // 
            SHA256Option.AutoSize = true;
            SHA256Option.Location = new Point(227, 60);
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
            MD5Option.Location = new Point(92, 60);
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
            // CustomHashTypeTab
            // 
            CustomHashTypeTab.Location = new Point(4, 26);
            CustomHashTypeTab.Name = "CustomHashTypeTab";
            CustomHashTypeTab.Padding = new Padding(3);
            CustomHashTypeTab.Size = new Size(492, 270);
            CustomHashTypeTab.TabIndex = 1;
            CustomHashTypeTab.Text = "Custom";
            CustomHashTypeTab.UseVisualStyleBackColor = true;
            // 
            // EncryptionTabPanel
            // 
            EncryptionTabPanel.Location = new Point(4, 26);
            EncryptionTabPanel.Name = "EncryptionTabPanel";
            EncryptionTabPanel.Padding = new Padding(3);
            EncryptionTabPanel.Size = new Size(512, 310);
            EncryptionTabPanel.TabIndex = 1;
            EncryptionTabPanel.Text = "Encryption";
            EncryptionTabPanel.UseVisualStyleBackColor = true;
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
            ResumeLayout(false);
        }

        #endregion

        private TabControl MainTabControl;
        private TabPage HashTabPanel;
        private TabPage EncryptionTabPanel;
        private TabControl HashTypeTabControl;
        private TabPage SystemHashTypeTab;
        private TabPage CustomHashTypeTab;
        private Label label1;
        private TextBox InputSystemHash;
        private Button CalculateSystemHashButton;
        private RadioButton SHA256Option;
        private RadioButton MD5Option;
        private RadioButton Sha512Option;
        private TextBox OutputSystemHash;
        private Label label2;
        private Button CopySystemHash;
    }
}