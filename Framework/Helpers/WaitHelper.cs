using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace Framework.Helpers
{
    public class WaitHelper : Settings
    {
        public static void Wait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
    }
}
