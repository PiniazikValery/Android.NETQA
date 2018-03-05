using OpenQA.Selenium;
using OpenQA.Selenium.Appium.PageObjects.Attributes;
using PlayMarket.TestFramework.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayMarket.Test.PageObjects
{
    public class StartPage : PageObject
    {

        [FindsByAndroidUIAutomator(Accessibility = "Show navigation drawer")]
        private IWebElement NavigationDrawer { get; set; }

        [FindsByAndroidUIAutomator(Accessibility = "Search")]
        private IWebElement Search { get; set; }

        [FindsByAndroidUIAutomator(Accessibility = "Voice Search")]
        private IWebElement VoiceSearch { get; set; }

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
