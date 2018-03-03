using Android.NETQA.PageObjects;
using Framework.StepsAbstraction;
using Serenity.Filters;


namespace Android.NETQA.Steps
{
    public class StartPageSteps: BaseSteps
    {      
        protected StartPage page=new StartPage();        
        
        [Step]
        public void SearchVkApp()
        {
            WaitLoadingPage();
            page.ClickSearch();
            page.SendKeysToSearchInput("VK"+"\n");
            Report.StepComplite();
        }      
    }
}
