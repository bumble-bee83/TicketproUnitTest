using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketproUnitTest
{
    /// <summary>
    /// Базовая страница
    /// </summary>
    /// <typeparam name="M"></typeparam>
    public class BasePage<M>
        where M : BasePageElementMap, new()
    {
        protected readonly string _url;

        public BasePage(string url)
        {
            this._url = url;
        }

        protected M Map
        {
            get
            {
                return new M();
            }
        }

        public void Navigate()
        {
            Driver.Browser.Navigate().GoToUrl(this._url);
        }
    }
}
