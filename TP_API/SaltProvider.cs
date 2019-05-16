using System;
using System.Text;

namespace TP_API
{
    public class SaltProvider : ISaltProvider
    {
        public const int SaltByteSize = 24;
        public byte[] GetSalt()
        {
            var rndNb = new Random().Next().ToString();

            var timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString();
            var salt = string.Concat(rndNb, timestamp);

            return Encoding.UTF8.GetBytes(salt);
        }
    }
}
