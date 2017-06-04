using OpenQA.Selenium;

namespace TicketproUnitTest
{
    public class MainPageElementMap : BasePageElementMap
    {
        public IWebElement LogonLink
        {
            get
            {
                return this._browser.FindElement(By.LinkText("ЛИЧНЫЙ КАБИНЕТ"));
            }
        }

        public IWebElement QueryANDWordsText
        {
            get
            {
                return this._browser.FindElement(By.Id("queryANDWords"));
            }
        }

        public IWebElement LinkToBuy
        {
            get
            {
                return this._browser.FindElement(By.LinkText("Концерт: Depeche Mode"));
            }
        }
    }
}
