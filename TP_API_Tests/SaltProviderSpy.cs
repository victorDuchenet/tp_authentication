using System.Text;
using TP_API;

namespace TP_API_Tests
{
    public class SaltProviderSpy : ISaltProvider
    {
        public bool isUsed { get; set; }

        public SaltProviderSpy()
        {
            isUsed = false;
        }

        public byte[] GetSalt()
        {
            isUsed = true;
            return new byte[0];
        }
    }
}
