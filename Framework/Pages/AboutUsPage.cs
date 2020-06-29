using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Framework.Pages
{
    public class AboutUsPage : Settings
    {
        //Elements
        private readonly static string aboutUsPageTitle = "//div[@class='container']//a[@class='collapse-link']";

        //Methods

        //Assertions
        public static void CheckIfAboutUsPageIsDisplayed()
        {
            try
            {
                IWebElement element = driver.FindElement(By.XPath(aboutUsPageTitle));
                Assert.IsTrue(element.Displayed);
                Console.WriteLine("Contact page is displayed correctly.");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong. Contact page is not displayed correctly.");
            }
        }
    }
}
