namespace DigitalniPotpis
{
    partial class frmDigitalniPotpis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDigitalniPotpis));
            btnCreateSecretKey = new Button();
            btnCreateKeyPair = new Button();
            btnAddFile = new Button();
            btnSymetricCrypto = new Button();
            btnAsymetricCrypto = new Button();
            btnHash = new Button();
            txtHash = new TextBox();
            btnSign = new Button();
            btnCheckSignature = new Button();
            SuspendLayout();
            // 
            // btnCreateSecretKey
            // 
            btnCreateSecretKey.Location = new Point(12, 9);
            btnCreateSecretKey.Name = "btnCreateSecretKey";
            btnCreateSecretKey.Size = new Size(170, 46);
            btnCreateSecretKey.TabIndex = 0;
            btnCreateSecretKey.Text = "Kreiraj tajni ključ";
            btnCreateSecretKey.UseVisualStyleBackColor = true;
            // 
            // btnCreateKeyPair
            // 
            btnCreateKeyPair.Location = new Point(188, 9);
            btnCreateKeyPair.Name = "btnCreateKeyPair";
            btnCreateKeyPair.Size = new Size(170, 46);
            btnCreateKeyPair.TabIndex = 1;
            btnCreateKeyPair.Text = "Kreiraj par ključeva";
            btnCreateKeyPair.UseVisualStyleBackColor = true;
            // 
            // btnAddFile
            // 
            btnAddFile.Enabled = false;
            btnAddFile.Location = new Point(12, 61);
            btnAddFile.Name = "btnAddFile";
            btnAddFile.Size = new Size(346, 46);
            btnAddFile.TabIndex = 2;
            btnAddFile.Text = "Dodaj datoteku za kriptiranje";
            btnAddFile.UseVisualStyleBackColor = true;
            // 
            // btnSymetricCrypto
            // 
            btnSymetricCrypto.Enabled = false;
            btnSymetricCrypto.Location = new Point(12, 113);
            btnSymetricCrypto.Name = "btnSymetricCrypto";
            btnSymetricCrypto.Size = new Size(170, 46);
            btnSymetricCrypto.TabIndex = 3;
            btnSymetricCrypto.Text = "Kriptiraj datoteku simetričnim algoritmom";
            btnSymetricCrypto.UseVisualStyleBackColor = true;
            // 
            // btnAsymetricCrypto
            // 
            btnAsymetricCrypto.Enabled = false;
            btnAsymetricCrypto.Location = new Point(188, 113);
            btnAsymetricCrypto.Name = "btnAsymetricCrypto";
            btnAsymetricCrypto.Size = new Size(170, 46);
            btnAsymetricCrypto.TabIndex = 4;
            btnAsymetricCrypto.Text = "Kriptiraj datoteku asimetričnim algoritmom";
            btnAsymetricCrypto.UseVisualStyleBackColor = true;
            // 
            // btnHash
            // 
            btnHash.Enabled = false;
            btnHash.Location = new Point(12, 165);
            btnHash.Name = "btnHash";
            btnHash.Size = new Size(346, 46);
            btnHash.TabIndex = 5;
            btnHash.Text = "Izračunaj sažetak datoteke";
            btnHash.UseVisualStyleBackColor = true;
            // 
            // txtHash
            // 
            txtHash.Enabled = false;
            txtHash.Location = new Point(12, 217);
            txtHash.Multiline = true;
            txtHash.Name = "txtHash";
            txtHash.Size = new Size(346, 234);
            txtHash.TabIndex = 6;
            // 
            // btnSign
            // 
            btnSign.Enabled = false;
            btnSign.Location = new Point(12, 457);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(170, 46);
            btnSign.TabIndex = 7;
            btnSign.Text = "Potpiši";
            btnSign.UseVisualStyleBackColor = true;
            // 
            // btnCheckSignature
            // 
            btnCheckSignature.Enabled = false;
            btnCheckSignature.Location = new Point(188, 457);
            btnCheckSignature.Name = "btnCheckSignature";
            btnCheckSignature.Size = new Size(170, 46);
            btnCheckSignature.TabIndex = 8;
            btnCheckSignature.Text = "Provjeri potpis";
            btnCheckSignature.UseVisualStyleBackColor = true;
            // 
            // frmDigitalniPotpis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(380, 515);
            Controls.Add(btnCheckSignature);
            Controls.Add(btnSign);
            Controls.Add(txtHash);
            Controls.Add(btnHash);
            Controls.Add(btnAsymetricCrypto);
            Controls.Add(btnSymetricCrypto);
            Controls.Add(btnAddFile);
            Controls.Add(btnCreateKeyPair);
            Controls.Add(btnCreateSecretKey);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "frmDigitalniPotpis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Digitalni potpis";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateSecretKey;
        private Button btnCreateKeyPair;
        private Button btnAddFile;
        private Button btnSymetricCrypto;
        private Button btnAsymetricCrypto;
        private Button btnHash;
        private TextBox txtHash;
        private Button btnSign;
        private Button btnCheckSignature;
    }
}
