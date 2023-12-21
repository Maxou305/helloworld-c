using helloworld;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace vraistests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBasicMessage()
        {
            string user = Environment.UserName;
            Message testMessage = new Message(9, 12, 18);
            string result = testMessage.BuildMessage(new FakeTime(), user);
            Assert.AreEqual(result, "Bonjour, maxime.chazard");
        }
        [TestMethod]
        public void TestOfDate()
        {
            string user = Environment.UserName;
            Message testMessage = new Message(9, 12, 18);

            string result = testMessage.BuildMessage(new FakeTime(2008, 5, 1, 18, 30, 52), user);
            Assert.AreEqual(result, "Bonsoir, maxime.chazard");
        }
        [TestMethod]
        public void TestThomas()
        {
            string user = Environment.UserName;
            Message testMessage = new Message(9, 12, 18);
            string result = testMessage.BuildMessage(new FakeTime(), user);
            Assert.AreNotEqual(result, "sudo mv /var/www/html/e-commerce/shop.php /var/www/html/e-commerce/index.php");
        }
    }
}
