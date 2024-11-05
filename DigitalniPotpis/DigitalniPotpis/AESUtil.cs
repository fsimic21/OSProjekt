using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace DigitalniPotpis
{
    static class AESUtil
    {
        public static void GenerateKey(string folderPath)
        {
            using (Aes aes = Aes.Create())
            {
                aes.GenerateKey();
                aes.GenerateIV();
                File.WriteAllText(Path.Combine(folderPath, "tajni_kljuc.txt"), Convert.ToBase64String(aes.Key));
                File.WriteAllText(Path.Combine(folderPath, "aes_iv.txt"), Convert.ToBase64String(aes.IV));
            }
        }

        public static Aes LoadAesKey(string folderPath)
        {
            Aes aes = Aes.Create();
            aes.Key = Convert.FromBase64String(File.ReadAllText(Path.Combine(folderPath, "tajni_kljuc.txt")));
            aes.IV = Convert.FromBase64String(File.ReadAllText(Path.Combine(folderPath, "aes_iv.txt")));
            return aes;
        }
        public static void Encrypt(string data, string folderPath)
        {
            using (Aes aes = LoadAesKey(folderPath))
            {
                byte[] encrypted;
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(data);
                    }
                    encrypted = msEncrypt.ToArray();
                    File.WriteAllText(Path.Combine(folderPath, "SimetricnoKriptirano.txt"), Convert.ToBase64String(encrypted));
                }
            }
        }
        public static string Decrypt(string folderPath)
        {
            using (Aes aes = LoadAesKey(folderPath))
            {
                string encryptedText = EncryptedText(folderPath);
                byte[] cipherBytes = Convert.FromBase64String(encryptedText);

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                using (MemoryStream ms = new MemoryStream(cipherBytes))
                using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                using (StreamReader sr = new StreamReader(cs, Encoding.UTF8))
                {
                    return sr.ReadToEnd();
                }
            }
        }

        public static string EncryptedText(string folderPath)
        {
            return File.ReadAllText(Path.Combine(folderPath, "SimetricnoKriptirano.txt"));
        }
    }
}
