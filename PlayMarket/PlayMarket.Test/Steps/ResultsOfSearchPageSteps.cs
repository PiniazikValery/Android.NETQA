using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayMarket.Test.PageObjects;
using PlayMarket.TestFramework.Steps;
using PlayMarket.TestFramework.Filters;
using PlayMarket.TestFramework.Drivers;

namespace PlayMarket.Test.Steps
{
    class ResultsOfSearchPageSteps : BaseSteps
    {
        protected ResultsOfSearchPage page = new ResultsOfSearchPage();        

        [Step]
        public void GoBack()
        {
            page.ClickBackButton();            
        }

        [Step]
        public void ScrollDown()
        {
            Driver.GetDriver().Swipe(500, 1500, 500, 100, 3000);            
        }

    }
}
