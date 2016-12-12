using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class PasswordTool
    {
        private byte[] CreateSalt()
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] salt = new byte[16];
            rng.GetBytes(salt);
            return salt;
        }
        public string getNewSalt()
        {
            return Convert.ToBase64String(CreateSalt());
        }

        private byte[] GetHash(string password, string salt)
        {
            byte[] passwordBytes = Convert.FromBase64String(password);
            byte[] saltBytes = Convert.FromBase64String(salt);
            byte[] passwordWithSalt = new byte[passwordBytes.Length + saltBytes.Length];
            for (int i = 0; i < passwordBytes.Length; i++)
            {
                passwordWithSalt[i] = passwordBytes[i];
            }
            for(int i = 0; i < saltBytes.Length; i++)
            {
                passwordWithSalt[passwordBytes.Length + i] = saltBytes[i];
            }
            HashAlgorithm algorythm = new SHA256Managed();
            return algorythm.ComputeHash(passwordWithSalt);
        }
        public string GetStringHash(string password, string salt)
        {
            return Convert.ToBase64String(GetHash(password, salt));
        }
        public bool CompareByteArrays(byte[] array1, byte[] array2)
        {
            if (array1.Length != array2.Length)
                return false;
            for (int i = 0; i < array1.Length; i++)
            {
                if(array1[i] != array2[i])
                {
                    return false;
                }
            }
            return true;
        }
        public bool ComparePasswordToHash(string password, string salt, string hash)
        {
            byte[] hashBytes = GetHash(password, salt);
            return CompareByteArrays(hashBytes, Convert.FromBase64String(hash));
        }

    }
}
