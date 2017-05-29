using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicketproUnitTest.Tests
{
    [TestClass]
    public class LogonPageUnitTest
    {
        [TestInitialize]
        public void SetupTest()
        {
            Driver.StartBrowser();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            Driver.StopBrowser();
        }

        [TestMethod]
        public void LogonTest()
        {
            LogonPage logonPage = new LogonPage();
            logonPage.Navigate();
            logonPage.SetUserName("bumble-bee83@mail.ru");
            logonPage.SetPassword("bumblebee83");
            logonPage.AgreeCheckBoxClick();
            logonPage.LogonButtonClick();
        }
    }
}
