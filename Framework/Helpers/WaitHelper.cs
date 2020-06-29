using OpenQA.Selenium;
using System;

namespace Framework.Helpers
{
    public class WaitHelper
    {
        public static void WaitUntilElementIsDisplayed(IWebElement element)
        {
            int i = 0;
            while (!element.Displayed)
            {
                System.Threading.Thread.Sleep(1000);
                i++;

                if (i == Settings.waitTime)
                    throw new Exception($"Something went wrong. Element '{element}' is not displayed correctly");
            }
        }
    }
}
