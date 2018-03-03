using Framework.Filters;
using Framework.PageObjectAbstraction;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.PageObjects.Attributes;


namespace Android.NETQA.PageObjects
{
    public class StartPage:PageObject
    {       
        [FindsByAndroidUIAutomator(Accessibility = "Show navigation drawer")]
        private IWebElement NavigationDrawer { get; set; }
                
        [FindsByAndroidUIAutomator(Accessibility = "Search")]
        private IWebElement Search { get; set; }

        [FindsByAndroidUIAutomator(Accessibility = "Voice Search")]
        private IWebElement VoiceSearch { get; set; }

        [Hidden]
        [FindsByAndroidUIAutomator(ID = "com.android.vending:id/search_box_text_input")]            
        private IWebElement HiddenSearchInput { get; set; }

        public void ClickNavigationDrawer()
        {
            NavigationDrawer.Click();            
        }

        public void ClickSearch()
        {
            Search.Click();            
        }

        public void ClickVoiceSearch()
        {
            VoiceSearch.Click();            
        }       

        public void SendKeysToSearchInput(string keys)
        {
            HiddenSearchInput.SendKeys(keys);            
        }     
    }
}
