using OpenQA.Selenium;
using OpenQA.Selenium.Appium.PageObjects.Attributes;
using Serenity.PageObjectAbstraction;

namespace Android.NETQA.PageObjects
{
    class ResultsOfSearchPage:PageObject
    {        
        [FindsByAndroidUIAutomator(Accessibility = "Back")]
        private IWebElement BackButton { get; set; }

        public void ClickBackButton()
        {
            BackButton.Click();
        }      
    }
}
