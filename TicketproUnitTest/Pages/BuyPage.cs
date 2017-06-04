using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketproUnitTest
{
    public class BuyPage : BasePage<BuyPageElementMap>
    {
        public BuyPage()
            : base("http://www.ticketpro.by/jnp/best/1980650-depeche-mode.html")
        {
        }

        public TicketPage TicketLinkClick()
        {
            this.Map.TicketLink.Click();
            return new TicketPage();
        }
    }
}
