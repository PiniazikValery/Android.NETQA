using Android.NETQA.PageObjects;
using Serenity.StepsAbstraction;

namespace Android.NETQA.Steps
{
    public class StartPageSteps: BaseSteps
    {      
        protected StartPage page=new StartPage();

        public object GetPage()
        {           
            return page;
        }

        public void SearchVkApp()
        {
            WaitLoadingPage();
            page.ClickSearch();
            page.SendKeysToSearchInput("VK"+"\n");
        }      
    }
}
