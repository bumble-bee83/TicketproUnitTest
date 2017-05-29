using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
