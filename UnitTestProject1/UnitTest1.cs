using System;
using Capítulo_8;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        public void FromEmailTestValid()
        {
            MailServerSettings target = new MailServerSettings();
            string expected = "test@abc.com";
            string actual;
            target.FromEmail = "test@ab.com";
            actual = target.FromEmail;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FromEmailTestNull()
        {
            MailServerSettings target = new MailServerSettings();
            target.FromEmail = "test";
            Assert.IsNull(target.FromEmail);
        }
    }
}
