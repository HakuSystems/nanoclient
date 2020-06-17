using System;
using System.IO;
using Microsoft.VisualBasic;
using System.Security.Cryptography;

namespace AutoUpdater
{
    static class Helper
    {
        public static void FileHash(string filePath)
        {
            byte[] fileBytes = File.ReadAllBytes(filePath);
            MD5CryptoServiceProvider targetCrypto = new MD5CryptoServiceProvider();
            byte[] byteHash = targetCrypto.ComputeHash(fileBytes);

            Convert.ToBase64String(byteHash);
        }

        public static string ConvertToHex(string baseString)
        {
            byte[] b64bytes = System.Convert.FromBase64String(baseString);

            string ret;
            foreach (byte b in b64bytes)
                ret += Conversion.Hex(b).PadLeft(2, '0');

            return ret.ToLower();
        }
    }
}