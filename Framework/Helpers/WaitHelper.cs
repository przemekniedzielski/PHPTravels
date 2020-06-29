using OpenQA.Selenium;
using System;

namespace Framework.Helpers
{
    public class WaitHelper : Settings
    {
        public static void Wait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public static void WaitUntilElementIsDisplayed(IWebElement element)
        {
            int i = 0;
            while (!element.Displayed)
            {
                System.Threading.Thread.Sleep(1000);
                i++;

                if (i == waitTime)
                    throw new Exception($"Something went wrong. Element '{element}' is not displayed correctly");
            }
        }
    }
}
