using System;
using System.Text;

namespace TP_API
{
    public class SaltProvider : ISaltProvider
    {
        private IRandom _randomProvider;
        private ITimestamp _timestampProvider;

        public SaltProvider(IRandom rnd, ITimestamp tstmp)
        {
            _randomProvider = rnd;
            _timestampProvider = tstmp;
        }

        public byte[] GetSalt()
        {
            var rndNb = _randomProvider.GetRandomValue().ToString();
            var timestamp = _timestampProvider.GetCurrentTimestamp();

            var salt = string.Concat(rndNb, timestamp);

            return Encoding.UTF8.GetBytes(salt);
        }
    }
}
