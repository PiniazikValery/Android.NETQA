using PlayMarket.Test.PageObjects;
using PlayMarket.TestFramework.Filters;
using PlayMarket.TestFramework.Steps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayMarket.Test.Steps
{
    public class StartPageSteps : BaseSteps
    {
        protected StartPage page = new StartPage();

        [Step]
        public void SearchVkApp()
        {            
            page.ClickSearch();
            page.SendKeysToSearchInput("VK" + "\n");
        }
    }
}
