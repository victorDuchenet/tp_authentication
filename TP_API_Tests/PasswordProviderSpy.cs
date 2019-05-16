using TP_API;

namespace TP_API_Tests
{
    public class PasswordProviderSpy : IPasswordProvider
    {
        public PasswordProviderSpy()
        {
            isUsed = false;
        }
        public bool isUsed { get; set; }
        public byte[] PasswordHash(string password, byte[] salt)
        {
            isUsed = true;
            return new byte[0];
        }
    }
}
