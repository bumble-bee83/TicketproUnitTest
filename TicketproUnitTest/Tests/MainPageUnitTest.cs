using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicketproUnitTest
{
    [TestClass]
    public class MainPageUnitTest// : BaseUnitTest
    {
        private string _username;
        private string _password;

        public MainPageUnitTest()
        {
            _username = "bumble-bee83@mail.ru";
            _password = "bumblebee83";
        }

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

        /// <summary>
        /// Вход с систему
        /// </summary>
        [TestMethod]
        public void LogonLinkClickTest()
        {
            MainPage mainPage = new MainPage();
            mainPage.Navigate();
            Assert.IsTrue(mainPage
                                .LogonLinkClick()                
                                .SetUserName(_username)
                                .SetPassword(_password)
                                .AgreeCheckBoxClick()   
                                .LogonButtonClick()
                                .GetUserMenuLabelText() == _username);                        
        }

        /// <summary>
        /// Выбор линка для покупки билетов
        /// </summary>
        [TestMethod]
        public void BuyTicketsTest()
        {
            MainPage mainPage = new MainPage();
            mainPage.Navigate();
            mainPage
                .LinkToBuyClick()
                .TicketLinkClick();
        }
    }
}
