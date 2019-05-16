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
        private string aSalt = "MTM1MDk5OTgwMzE1NTgwMTQxMjI4ODc=";
        private string aPassword = "monmdp";
        private string aPasswordHash = "HxCyv8PoIteRcB8rpbda0ak1IlyK/DEfl6qM+/k0gyM=";

        [Test]
        public void ReturnEvenHash()
        {
            // Arrange
            var provider = new PasswordProvider();
            var salt = Convert.FromBase64String(aSalt);

            // Act
            var passwordHashResult = provider.PasswordHash(aPassword, salt);

            // Assert
            Assert.AreEqual(aPasswordHash, Convert.ToBase64String(passwordHashResult));
        }

    }
}
