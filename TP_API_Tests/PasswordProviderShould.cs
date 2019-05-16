using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TP_API;

namespace TP_API_Tests
{
    [TestFixture]
    public class PasswordProviderShould
    {
        private string aPassword = "monmdp";
        private string aPasswordHash = "XgHExFshcNqeqkoYPwJVSgJiY8va+WrAZo1mEIBaniU=";

        [Test]
        public void ReturnEvenHash()
        {
            // Arrange
            var provider = new PasswordProvider();

            var saltProvider = new SaltProvider(new FakeRandomProvider(), new FakeTimestampProvider());
            var salt = saltProvider.GetSalt();

            // Act
            var passwordHashResult = provider.PasswordHash(aPassword, salt);

            // Assert
            Assert.AreEqual(aPasswordHash, Convert.ToBase64String(passwordHashResult));
        }

    }
}
