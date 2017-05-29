using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TicketproUnitTest
{
    public class LogonPageElementMap : BasePageElementMap
    {
        public IWebElement UserNameInput
        {
            get
            {
                return this._browser.FindElement(By.Id("username"));
            }
        }
        public IWebElement PasswordInput
        {
            get
            {
                return this._browser.FindElement(By.Id("password"));
            }
        }

        public IWebElement AgreeCheckBox
        {
            get
            {
                return this._browser.FindElement(By.Id("agree"));
            }
        }

        public IWebElement LogonButton
        {
            get
            {
                return this._browser.FindElement(By.ClassName("left95"));
            }
        }
    }
}
