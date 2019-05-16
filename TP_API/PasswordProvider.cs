using System.Security.Cryptography;
using System.Text;

namespace TP_API
{
    public class PasswordProvider: IPasswordProvider
    {
        public byte[] PasswordHash(string password, byte[] salt)
        {
            HashAlgorithm algorithm = new SHA256Managed();
            var pwd = Encoding.UTF8.GetBytes(password);
            byte[] plainTextWithSaltBytes = new byte[pwd.Length + salt.Length];

            for (int i = 0; i < pwd.Length; i++)
            {
                plainTextWithSaltBytes[i] = pwd[i];
            }

            for (int i = 0; i < salt.Length; i++)
            {
                plainTextWithSaltBytes[pwd.Length + i] = salt[i];
            }

            return algorithm.ComputeHash(plainTextWithSaltBytes);
        }
    }
}
