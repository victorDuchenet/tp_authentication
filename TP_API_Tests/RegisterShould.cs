using NUnit.Framework;
using System;
using TP_API;

namespace TP_API_Tests
{
    [TestFixture]
    public class AuthenticationShould
    {
        private Authentication _authentication;
        private SaltProviderSpy _saltProvider;
        private PasswordProviderSpy _passwordProvider;

        [SetUp]
        public void SetUp()
        {
            _saltProvider = new SaltProviderSpy();
            _passwordProvider = new PasswordProviderSpy();
            _authentication = new Authentication(_saltProvider, _passwordProvider);
        }

        [Test]
        public void RegisterUser()
        {
            var user = _authentication.Register("victor", " monmdp");
            Assert.True(_saltProvider.isUsed); 
            Assert.True(_passwordProvider.isUsed);
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void ThrowErrorWhenUsernameIsEmptyOrNull(string value)
        {

            Assert.Throws<ArgumentNullException>(() => _authentication.Register(value, "monmdp"));
        }


        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void ThrowErrorWhenPasswordIsEmptyOrNull(string value)
        {
            Assert.Throws<ArgumentNullException>(() => _authentication.Register("victor", value));
        }


    }
}
