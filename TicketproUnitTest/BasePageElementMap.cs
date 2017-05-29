using OpenQA.Selenium;

namespace TicketproUnitTest
{
    public class BasePageElementMap
    {
        protected IWebDriver _browser;
        public BasePageElementMap()
        {
            this._browser = Driver.Browser;
        }
    }
}
