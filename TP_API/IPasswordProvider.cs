namespace TP_API
{
    public interface IPasswordProvider
    {
        byte[] PasswordHash(string password, byte[] salt);
    }
}
