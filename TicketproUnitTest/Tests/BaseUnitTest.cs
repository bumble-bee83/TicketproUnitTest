using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicketproUnitTest
{
    [TestClass]
    public class BaseUnitTest
    {
        [ClassInitialize]
        public void SetupTest()
        {
            Driver.StartBrowser();            
        }

        [ClassCleanup]
        public void TeardownTest()
        {
            Driver.StopBrowser();
        }
    }
}
