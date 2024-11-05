using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace DigitalniPotpis
{
    public partial class frmDigitalniPotpis : Form
    {
        private string? originalFile;
        private string? aesKeyPath;
        private string? rsaKeyPath;
        private string? symetriCryptedPath;
        private string? asymetriCryptedPath;
        private string? hashPath;
        private string? signaturePath;
        public frmDigitalniPotpis()
        {
            InitializeComponent();
        }

        private void btnCreateSecretKey_Click(object sender, EventArgs e)
        {
            aesKeyPath = SelectFolder("Odaberite direktorij za spremanje kljuèeva");
            GenerateKey(AESUtil.GenerateKey, "AES", aesKeyPath);
            btnSymetricCrypto.Enabled = originalFile != null;

        }

        private void btnCreateKeyPair_Click(object sender, EventArgs e)
        {
            rsaKeyPath = SelectFolder("Odaberite direktorij za spremanje kljuèeva");
            GenerateKey(RSAUtil.GenerateKey, "RSA", rsaKeyPath);
            btnSign.Enabled = hashPath != null;

        }

        private void GenerateKey(Action<string> generateMethod, string keyType, string folderPath)
        {
            if (string.IsNullOrEmpty(folderPath))
            {
                MessageBox.Show("Direktorij koji ste odabrali ne postoji", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            generateMethod(folderPath);
            Console.WriteLine($"{keyType} kljuèevi su uspješno generirani i spremljeni.");
            btnAddFile.Enabled = true;
        }

        private string? SelectFolder(string message)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = message;
                folderBrowserDialog.ShowNewFolderButton = true;

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    return folderBrowserDialog.SelectedPath;
                }
            }
            return null;
        }
        private void btnAddFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Title = "Odaberite tekstualnu datoteku";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    originalFile = File.ReadAllText(openFileDialog.FileName);
                    MessageBox.Show("Datoteka uspješno uèitana!", "Uèitavanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            btnSymetricCrypto.Enabled = aesKeyPath != null;
            btnAsymetricCrypto.Enabled = rsaKeyPath != null;
            btnHash.Enabled = true;

        }
        private void btnSymetricCrypto_Click(object sender, EventArgs e)
        {
            symetriCryptedPath = SelectFolder("Odaberite direktorij za spremanje tekstualne datoteke kriptirane simetriènim algoritmom");
            Aes aesKey = AESUtil.LoadAesKey(aesKeyPath);
            AESUtil.Encrypt(originalFile, symetriCryptedPath);

            btnHash.Enabled = true;
            btnSymetricDecryption.Enabled = true;
        }
        private void btnSymetricDecryption_Click(object sender, EventArgs e)
        {
            txtCryptedFile.Text = AESUtil.EncryptedText(symetriCryptedPath);
            try
            {
                txtDecrypted.Text = AESUtil.Decrypt(aesKeyPath);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Pogrška prilikom dekriptiranja!\nKriptirana datoteka ili kljuè su vjerojatno izmjenjeni.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAsymetricCrypto_Click(object sender, EventArgs e)
        {
            asymetriCryptedPath = SelectFolder("Odaberite direktorij za spremanje tekstualne datoteke kriptirane asimetriènim algoritmom");
            RSA publicKey = RSAUtil.LoadPublicKey(rsaKeyPath);
            try
            {
                RSAUtil.Encrypt(originalFile, asymetriCryptedPath, publicKey);
                btnHash.Enabled = true;
                btnAsymetricDecrypt.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pogrška prilikom dekriptiranja!\nKriptirana datoteka ili kljuè su vjerojatno izmjenjeni", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void btnAsymetricDecrypt_Click(object sender, EventArgs e)
        {
            txtCryptedFile.Text = RSAUtil.EncryptedText(asymetriCryptedPath);
            RSA privateKey = RSAUtil.LoadPrivateKey(rsaKeyPath);
            txtDecrypted.Text = RSAUtil.Decrypt(RSAUtil.EncryptedText(asymetriCryptedPath), privateKey);
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            hashPath = SelectFolder("Odaberite direktorij za spremanje sažetka datoteke");
            txtHash.Text = SignatureUtil.HashFile(hashPath, originalFile);
            btnSign.Enabled = true;

        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            SignatureUtil.GenerateKey(hashPath);
            SignatureUtil.SignFile(hashPath);
            MessageBox.Show("Potpisana datoteka", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnCheckSignature.Enabled = true;
        }

        private void btnCheckSignature_Click(object sender, EventArgs e)
        {
            txtSignature.Text = SignatureUtil.LoadSignatureString(hashPath);
            bool valid = SignatureUtil.VerifySignature(hashPath, SignatureUtil.LoadSignature(hashPath));
            if (valid) MessageBox.Show("Potpis je valjan", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Potpis nije valjan", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtSignedFile.Text = originalFile;
        }
    }
}
