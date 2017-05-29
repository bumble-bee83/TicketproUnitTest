using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicketproUnitTest
{
    [TestClass]
    public class MainPageUnitTest
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
        public void LogonLinkClickTest()
        {
            MainPage mainPage = new MainPage();
            mainPage.Navigate();
            mainPage.LogonLinkClick();
        }
    }
}
