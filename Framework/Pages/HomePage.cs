using System;
using NUnit.Framework;
using OpenQA.Selenium;
using static Framework.Helpers.WaitHelper;

namespace Framework.Pages
{
    public class HomePage : Settings
    {
        //Elements
        private readonly static string logo = "//div[@class='header-top']//div[contains(@class, 'col-md-4 col-2 o2')]//img";

        //Methods

        //Assertions
        public static void CheckIfLogoIsDisplayed()
        {
            Wait();
            IWebElement element = driver.FindElement(By.XPath(logo));
            try
            {
                Assert.IsTrue(element.Displayed);
                Console.WriteLine("Logo is displayed correctly.");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong. Logo is not displayed correctly.");
            }
        }

    }
}
