using Android.NETQA.PageObjects;
using Serenity.Drivers;
using Serenity.StepsAbstraction;

namespace Android.NETQA.Steps
{
    class ResultsOfSearchPageSteps : BaseSteps
    {
        protected ResultsOfSearchPage page =new ResultsOfSearchPage();        

        public object GetPage()
        {
            return page;
        }

        public void GoBack()
        {
            WaitLoadingPage();
            page.ClickBackButton();
        }

        public void ScrollDown()
        {
            WaitLoadingPage();
            Driver.GetDriver().Swipe(500, 1500, 500, 100, 3000);
        }        
    }
}
