using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace DigitalniPotpis
{
    static class RSAUtil
    {
        public static void GenerateKey(string folderPath)
        {
            using (RSA rsa = RSA.Create(2048))
            {
                var privateKey = rsa.ExportRSAPrivateKey();
                var publicKey = rsa.ExportRSAPublicKey();

                File.WriteAllText(Path.Combine(folderPath, "privatni_kljuc.txt"), Convert.ToBase64String(privateKey));
                File.WriteAllText(Path.Combine(folderPath, "javni_kljuc.txt"), Convert.ToBase64String(publicKey));
            }
        }
        public static RSA LoadPrivateKey(string folderPath)
        {
            var privateKeyBytes = Convert.FromBase64String(File.ReadAllText(Path.Combine(folderPath, "privatni_kljuc.txt")));
            RSA rsa = RSA.Create();
            rsa.ImportRSAPrivateKey(privateKeyBytes, out _);
            return rsa;
        }
        public static RSA LoadPublicKey(string folderPath)
        {
            var publicKeyBytes = Convert.FromBase64String(File.ReadAllText(Path.Combine(folderPath, "javni_kljuc.txt")));
            RSA rsa = RSA.Create();
            rsa.ImportRSAPublicKey(publicKeyBytes, out _);
            return rsa;
        }
        public static void Encrypt(string data, string folderPath, RSA publicKey)
        {
            using (RSA rsa = publicKey)
            {
                byte[] dataBytes = Encoding.UTF8.GetBytes(data);
                byte[] encryptedBytes = rsa.Encrypt(dataBytes, RSAEncryptionPadding.Pkcs1);
                File.WriteAllText(Path.Combine(folderPath, "AsimetricnoKriptirano.txt"), Convert.ToBase64String(encryptedBytes));

            }
        }
        public static string Decrypt(string encryptedData, RSA privateKey)
        {
            using (RSA rsa = privateKey)
            {
                byte[] encryptedBytes = Convert.FromBase64String(encryptedData);
                byte[] decryptedBytes = rsa.Decrypt(encryptedBytes, RSAEncryptionPadding.Pkcs1);
                return Encoding.UTF8.GetString(decryptedBytes);
            }
        }
        public static string EncryptedText(string folderPath)
        {
            return File.ReadAllText(Path.Combine(folderPath, "AsimetricnoKriptirano.txt"));
        }
    }
}
