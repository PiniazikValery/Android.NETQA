using Android.NETQA.PageObjects;
using Framework.Drivers;
using Framework.StepsAbstraction;
using Serenity.Filters;

namespace Android.NETQA.Steps
{
    class ResultsOfSearchPageSteps : BaseSteps
    {
        protected ResultsOfSearchPage page =new ResultsOfSearchPage();               
        
        [Step]
        public void GoBack()
        {
            WaitLoadingPage();
            page.ClickBackButton();
            Report.StepComplite();
        }
        
        [Step]
        public void ScrollDown()
        {
            WaitLoadingPage();
            Driver.GetDriver().Swipe(500, 1500, 500, 100, 3000);
            Report.StepComplite();
        }     

    }
}
