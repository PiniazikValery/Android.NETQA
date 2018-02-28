using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using System;

namespace Serenity.Drivers
{
    public class Driver
    {
        private static AppiumDriver<AndroidElement> _driver { get; set; }

        public static void InitDriver()
        {            
            DesiredCapabilities cap = new DesiredCapabilities();
            cap.SetCapability("avd", "Nexus_5X_API_27");
            cap.SetCapability("automationName", "Appium");
            cap.SetCapability("platformName", "Android");
            cap.SetCapability("platformVersion", "8.1.0");
            cap.SetCapability("deviceName", "Nexus 5X");
            cap.SetCapability("newCommandTimeout", 120);
            cap.SetCapability("fullReset", false);
            cap.SetCapability("appPackage", "com.android.vending");
            cap.SetCapability("appActivity", "com.android.vending.AssetBrowserActivity");
            _driver = new AndroidDriver<AndroidElement>(new Uri("http://localhost:4723/wd/hub"), cap, TimeSpan.FromSeconds(30000));
        }

        public static AppiumDriver<AndroidElement> GetDriver()
        {            
            return _driver;
        }

        public static void Close()
        {
            _driver.Quit();
        }
    }
}
