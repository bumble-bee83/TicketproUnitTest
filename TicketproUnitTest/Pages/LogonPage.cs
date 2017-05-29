using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketproUnitTest
{
    public class LogonPage : BasePage<LogonPageElementMap>
    {
        public LogonPage()
            : base("https://shop.ticketpro.by/RU/Account/LogOn")
        {
        }

        public LogonPage SetUserName(string userName)
        {
            this.Map.UserNameInput.Clear();
            this.Map.UserNameInput.SendKeys(userName);
            return new LogonPage();
        }

        public LogonPage SetPassword(string password)
        {
            this.Map.PasswordInput.Clear();
            this.Map.PasswordInput.SendKeys(password);
            return new LogonPage();
        }

        public LogonPage AgreeCheckBoxClick()
        {
            this.Map.AgreeCheckBox.Click();
            return new LogonPage();
        }

        public LogonPage LogonButtonClick()
        {
            this.Map.LogonButton.Click();
            return new LogonPage();
        }
    }
}
