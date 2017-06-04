using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketproUnitTest
{
    /// <summary>
    /// Страница удачного входа
    /// </summary>
    public class SearchPage : BasePage<SearchPageElementMap>
    {
        public SearchPage()
                : base("https://shop.ticketpro.by/RU/Event/Search")
        {
        }

        /// <summary>
        /// Возврат text user_menu_label
        /// </summary>
        /// <returns></returns>
        public string GetUserMenuLabelText()
        {
            return this.Map.UserMenuLabel.Text;
        }
    }
}
