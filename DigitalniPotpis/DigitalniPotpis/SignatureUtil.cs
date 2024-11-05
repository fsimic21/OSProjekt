using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniPotpis
{
    internal class SignatureUtil
    {
        public static string HashFile(string folderPath, string data)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] dataBytes = Encoding.UTF8.GetBytes(data);
                byte[] hashBytes = sha256.ComputeHash(dataBytes);
                string hashBase64 = Convert.ToBase64String(hashBytes);
                File.WriteAllText(Path.Combine(folderPath, "sazetakDatoteke.txt"), hashBase64);
                return hashBase64;
            }
        }

        public static byte[] LoadHashFile(string folderPath)
        {
            string hashBase64 = File.ReadAllText(Path.Combine(folderPath, "sazetakDatoteke.txt"));
            return Convert.FromBase64String(hashBase64);
        }

        public static void SignFile(string hashPath, string privateKeyPath)
        {
            byte[] fileHash = LoadHashFile(hashPath);

            using (RSA rsa = RSAUtil.LoadPrivateKey(privateKeyPath))
            {
                byte[] signature = rsa.SignHash(fileHash, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
                File.WriteAllText(Path.Combine(hashPath, "potpisanaDatoteka.txt"), Convert.ToBase64String(signature));
            }
        }


        public static bool VerifySignature(string filePath, byte[] signature, string publicKeyPath)
        {
            byte[] fileHash = LoadHashFile(filePath);

            using (RSA rsa = RSAUtil.LoadPublicKey(publicKeyPath))
            {
                return rsa.VerifyHash(fileHash, signature, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
            }
        }

        public static byte[] LoadSignature(string signatureFilePath)
        {
            return Convert.FromBase64String(File.ReadAllText(Path.Combine(signatureFilePath, "potpisanaDatoteka.txt")));
        }
        public static string LoadSignatureString(string signatureFilePath)
        {
            return File.ReadAllText(Path.Combine(signatureFilePath, "potpisanaDatoteka.txt"));
        }

    }
}
