using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketproUnitTest
{
    public class BuyPageElementMap : BasePageElementMap
    {
        public IWebElement TicketLink
        {
            get
            {
                return this._browser.FindElement(By.LinkText("Билеты"));
            }
        }
    }
}
