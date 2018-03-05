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
    public class ResultsOfSearchPage : PageObject
    {

        [FindsByAndroidUIAutomator(Accessibility = "Back")]
        private IWebElement BackButton { get; set; }

        public void ClickBackButton()
        {
            BackButton.Click();
        }
    }
}
