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
    }
}
