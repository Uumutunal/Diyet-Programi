using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace EFDiyetProgramiProje_PL.StaticMethods
{

    public static class Sha256Hasher
    {
        public static string ComputeSha256Hash(string sifre)
        {
            using (SHA256 sha256 = SHA256.Create())
            {

                // Compute the hash of the given string
                byte[] hashValue = sha256.ComputeHash(Encoding.UTF8.GetBytes(sifre));

                // Convert the byte array to string format
                return BitConverter.ToString(hashValue).Replace("-", "");

            }
        }
    }
}

