using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketproUnitTest
{
    public class TicketPage : BasePage<TicketPageElementMap>
    {
        public TicketPage()
            : base("https://shop.ticketpro.by/ru/Event/Detail/36299/концерт-depeche-mode")
        {
        }
    }
}
