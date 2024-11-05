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

        public static void GenerateKey(string folderPath)
        {
            using (RSA rsa = RSA.Create(2048))
            {
                var privateKey = rsa.ExportRSAPrivateKey();
                var publicKey = rsa.ExportRSAPublicKey();

                File.WriteAllText(Path.Combine(folderPath, "potpis_privatni_kljuc.txt"), Convert.ToBase64String(privateKey));
                File.WriteAllText(Path.Combine(folderPath, "potpis_javni_kljuc.txt"), Convert.ToBase64String(publicKey));
            }
        }

        public static RSA LoadPrivateKey(string folderPath)
        {
            var privateKeyBytes = Convert.FromBase64String(File.ReadAllText(Path.Combine(folderPath, "potpis_privatni_kljuc.txt")));
            RSA rsa = RSA.Create();
            rsa.ImportRSAPrivateKey(privateKeyBytes, out _);
            return rsa;
        }
        public static RSA LoadPublicKey(string folderPath)
        {
            var publicKeyBytes = Convert.FromBase64String(File.ReadAllText(Path.Combine(folderPath, "potpis_javni_kljuc.txt")));
            RSA rsa = RSA.Create();
            rsa.ImportRSAPublicKey(publicKeyBytes, out _);
            return rsa;
        }

        public static byte[] LoadHashFile(string folderPath)
        {
            string hashBase64 = File.ReadAllText(Path.Combine(folderPath, "sazetakDatoteke.txt"));
            return Convert.FromBase64String(hashBase64);
        }

        public static void SignFile(string hashPath)
        {
            byte[] fileHash = LoadHashFile(hashPath);

            using (RSA rsa = LoadPrivateKey(hashPath))
            {
                byte[] signature = rsa.SignHash(fileHash, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
                File.WriteAllText(Path.Combine(hashPath, "potpisanaDatoteka.txt"), Convert.ToBase64String(signature));
            }
        }


        public static bool VerifySignature(string filePath, byte[] signature)
        {
            byte[] fileHash = LoadHashFile(filePath);

            using (RSA rsa = LoadPublicKey(filePath))
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
