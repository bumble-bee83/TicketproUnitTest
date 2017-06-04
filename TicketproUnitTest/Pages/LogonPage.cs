using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketproUnitTest
{
    /// <summary>
    /// Страница с формой входа
    /// </summary>
    public class LogonPage : BasePage<LogonPageElementMap>
    {
        public LogonPage()
            : base("https://shop.ticketpro.by/RU/Account/LogOn")
        {
        }

        /// <summary>
        /// Ввод username
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public LogonPage SetUserName(string userName)
        {
            this.Map.UserNameInput.Clear();
            this.Map.UserNameInput.SendKeys(userName);
            return new LogonPage();
        }

        /// <summary>
        /// Ввод password
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public LogonPage SetPassword(string password)
        {
            this.Map.PasswordInput.Clear();
            this.Map.PasswordInput.SendKeys(password);
            return new LogonPage();
        }

        /// <summary>
        /// Check argeecheckbox
        /// </summary>
        /// <returns></returns>
        public LogonPage AgreeCheckBoxClick()
        {
            this.Map.AgreeCheckBox.Click();
            return new LogonPage();
        }

        /// <summary>
        /// Click logonbutton
        /// </summary>
        /// <returns></returns>
        public SearchPage LogonButtonClick()
        {
            this.Map.LogonButton.Click();
            return new SearchPage();
        }
    }
}
