using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketproUnitTest
{
    public class MainPage : BasePage<MainPageElementMap>
    {
        public MainPage()
            : base("http://www.ticketpro.by")
        {          
        }

        public void LogonLinkClick()
        {
            this.Map.LogonLink.Click();
        }
    }
}
