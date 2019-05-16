using System;

namespace TP_API
{
    public class Authentication
    {
        private ISaltProvider _saltProvider;
        private IPasswordProvider _passwordProvider;
        public Authentication( ISaltProvider saltProvider, IPasswordProvider passwordProvider)
        {
            _passwordProvider = passwordProvider;
            _saltProvider = saltProvider;
        }

        public User Register(string username, string mdp)
        {
            if (string.IsNullOrEmpty(mdp))
                throw new ArgumentNullException(nameof(mdp));

            if (string.IsNullOrEmpty(username))
                throw new ArgumentNullException(nameof(username));

            var salt = _saltProvider.GetSalt();
            var passwordHash = _passwordProvider.PasswordHash(mdp, salt);

            return new User
            {
                Id = Guid.NewGuid().ToString(),
                Username = username,
                HashedPassword = Convert.ToBase64String(passwordHash),
                Salt = Convert.ToBase64String(salt),
            };
        }
    }
}
