using System;
using NUnit.Framework;
using OpenQA.Selenium;
using Framework.Helpers;

namespace Framework.Pages
{
    public class HomePage : Settings
    {
        //Elements
        private readonly static string logo = "//div[@class='header-top']//div[contains(@class, 'col-md-4 col-2 o2')]//img";

        //Methods

        //Assertions
        public static void CheckIfHomePageIsDisplayed()
        {
            WaitHelper.EnableImplicitWait();
            try
            {
                IWebElement element = driver.FindElement(By.XPath(logo));
                Assert.IsTrue(element.Displayed);
                Console.WriteLine("'Home' page is displayed correctly.");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong. 'Home' page is not displayed correctly.");
                throw;
            }
        }
    }
}
