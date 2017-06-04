using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TicketproUnitTest
{
    public class SearchPageElementMap : BasePageElementMap
    {
        public IWebElement UserMenuLabel
        {
            get
            {
                return this._browser.FindElement(By.ClassName("user_menu_label"));
            }
        }
    }
}
