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
            btnSymetricDecryption = new Button();
            btnAsymetricDecrypt = new Button();
            txtCryptedFile = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtDecrypted = new TextBox();
            label3 = new Label();
            txtSignature = new TextBox();
            label4 = new Label();
            txtSignedFile = new TextBox();
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
            btnCreateSecretKey.Click += btnCreateSecretKey_Click;
            // 
            // btnCreateKeyPair
            // 
            btnCreateKeyPair.Location = new Point(188, 9);
            btnCreateKeyPair.Name = "btnCreateKeyPair";
            btnCreateKeyPair.Size = new Size(170, 46);
            btnCreateKeyPair.TabIndex = 1;
            btnCreateKeyPair.Text = "Kreiraj par ključeva";
            btnCreateKeyPair.UseVisualStyleBackColor = true;
            btnCreateKeyPair.Click += btnCreateKeyPair_Click;
            // 
            // btnAddFile
            // 
            btnAddFile.Location = new Point(12, 61);
            btnAddFile.Name = "btnAddFile";
            btnAddFile.Size = new Size(346, 46);
            btnAddFile.TabIndex = 2;
            btnAddFile.Text = "Dodaj datoteku za kriptiranje";
            btnAddFile.UseVisualStyleBackColor = true;
            btnAddFile.Click += btnAddFile_Click;
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
            btnSymetricCrypto.Click += btnSymetricCrypto_Click;
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
            btnAsymetricCrypto.Click += btnAsymetricCrypto_Click;
            // 
            // btnHash
            // 
            btnHash.Enabled = false;
            btnHash.Location = new Point(364, 9);
            btnHash.Name = "btnHash";
            btnHash.Size = new Size(346, 46);
            btnHash.TabIndex = 5;
            btnHash.Text = "Izračunaj sažetak datoteke";
            btnHash.UseVisualStyleBackColor = true;
            btnHash.Click += btnHash_Click;
            // 
            // txtHash
            // 
            txtHash.Enabled = false;
            txtHash.Location = new Point(364, 61);
            txtHash.Multiline = true;
            txtHash.Name = "txtHash";
            txtHash.Size = new Size(346, 98);
            txtHash.TabIndex = 6;
            // 
            // btnSign
            // 
            btnSign.Enabled = false;
            btnSign.Location = new Point(364, 162);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(170, 46);
            btnSign.TabIndex = 7;
            btnSign.Text = "Potpiši";
            btnSign.UseVisualStyleBackColor = true;
            btnSign.Click += btnSign_Click;
            // 
            // btnCheckSignature
            // 
            btnCheckSignature.Enabled = false;
            btnCheckSignature.Location = new Point(540, 162);
            btnCheckSignature.Name = "btnCheckSignature";
            btnCheckSignature.Size = new Size(170, 46);
            btnCheckSignature.TabIndex = 8;
            btnCheckSignature.Text = "Provjeri potpis";
            btnCheckSignature.UseVisualStyleBackColor = true;
            btnCheckSignature.Click += btnCheckSignature_Click;
            // 
            // btnSymetricDecryption
            // 
            btnSymetricDecryption.Enabled = false;
            btnSymetricDecryption.Location = new Point(12, 162);
            btnSymetricDecryption.Name = "btnSymetricDecryption";
            btnSymetricDecryption.Size = new Size(170, 46);
            btnSymetricDecryption.TabIndex = 9;
            btnSymetricDecryption.Text = "Dekriptiraj datoteku simetričnim algoritmom";
            btnSymetricDecryption.UseVisualStyleBackColor = true;
            btnSymetricDecryption.Click += btnSymetricDecryption_Click;
            // 
            // btnAsymetricDecrypt
            // 
            btnAsymetricDecrypt.Enabled = false;
            btnAsymetricDecrypt.Location = new Point(188, 162);
            btnAsymetricDecrypt.Name = "btnAsymetricDecrypt";
            btnAsymetricDecrypt.Size = new Size(170, 46);
            btnAsymetricDecrypt.TabIndex = 10;
            btnAsymetricDecrypt.Text = "Dekriptiraj datoteku asimetričnim algoritmom";
            btnAsymetricDecrypt.UseVisualStyleBackColor = true;
            btnAsymetricDecrypt.Click += btnAsymetricDecrypt_Click;
            // 
            // txtCryptedFile
            // 
            txtCryptedFile.Enabled = false;
            txtCryptedFile.Location = new Point(12, 229);
            txtCryptedFile.Multiline = true;
            txtCryptedFile.Name = "txtCryptedFile";
            txtCryptedFile.ReadOnly = true;
            txtCryptedFile.Size = new Size(346, 158);
            txtCryptedFile.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 211);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 12;
            label1.Text = "Kriptirani tekst";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 392);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 13;
            label2.Text = "Dekriptirani tekst";
            // 
            // txtDecrypted
            // 
            txtDecrypted.Enabled = false;
            txtDecrypted.Location = new Point(12, 410);
            txtDecrypted.Multiline = true;
            txtDecrypted.Name = "txtDecrypted";
            txtDecrypted.ReadOnly = true;
            txtDecrypted.Size = new Size(346, 158);
            txtDecrypted.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(364, 211);
            label3.Name = "label3";
            label3.Size = new Size(147, 15);
            label3.TabIndex = 15;
            label3.Text = "Digitalni potpis iz datoteke";
            // 
            // txtSignature
            // 
            txtSignature.Location = new Point(364, 229);
            txtSignature.Multiline = true;
            txtSignature.Name = "txtSignature";
            txtSignature.ReadOnly = true;
            txtSignature.Size = new Size(346, 158);
            txtSignature.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(364, 392);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 17;
            label4.Text = "Potpisana datoteka";
            // 
            // txtSignedFile
            // 
            txtSignedFile.Location = new Point(364, 410);
            txtSignedFile.Multiline = true;
            txtSignedFile.Name = "txtSignedFile";
            txtSignedFile.ReadOnly = true;
            txtSignedFile.Size = new Size(346, 158);
            txtSignedFile.TabIndex = 18;
            // 
            // frmDigitalniPotpis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(722, 580);
            Controls.Add(txtSignedFile);
            Controls.Add(label4);
            Controls.Add(txtSignature);
            Controls.Add(label3);
            Controls.Add(txtDecrypted);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCryptedFile);
            Controls.Add(btnAsymetricDecrypt);
            Controls.Add(btnSymetricDecryption);
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
        private Button btnSymetricDecryption;
        private Button btnAsymetricDecrypt;
        private TextBox txtCryptedFile;
        private Label label1;
        private Label label2;
        private TextBox txtDecrypted;
        private Label label3;
        private TextBox txtSignature;
        private Label label4;
        private TextBox txtSignedFile;
    }
}
