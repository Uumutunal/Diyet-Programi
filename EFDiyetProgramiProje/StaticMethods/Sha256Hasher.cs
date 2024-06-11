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

                byte[] hashValue = sha256.ComputeHash(Encoding.UTF8.GetBytes(sifre));

                return BitConverter.ToString(hashValue).Replace("-", "");

            }
        }
    }
}

