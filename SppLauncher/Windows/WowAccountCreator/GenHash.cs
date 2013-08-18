using System;
using System.Security.Cryptography;
using System.Text;

namespace SppLauncher.Windows.WowAccountCreator
{
    class GenHash
    {
        public string Sha1_hash(string user, string pass)
        {
            UTF8Encoding ue = new UTF8Encoding();
            byte[] bytes = ue.GetBytes(user.ToUpper() + ":" + pass.ToUpper());
            SHA1 sha = new SHA1CryptoServiceProvider();
            byte[] hashBytes = sha.ComputeHash(bytes);
            string hashString = "";
            for (int i = 0; i < hashBytes.Length; i++)
            {
                hashString += Convert.ToString(hashBytes[i], 16).PadLeft(2, '0');
            }

            return hashString.ToUpper();
        }
    }
}
