using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Framework.Pages
{
    public class ContactPage : Settings
    {
        //Elements
        private readonly static string contactPageTitle = "//div[@class='container']//h2";

        //Methods

        //Assertions
        public static void CheckIfContactPageIsDisplayed()
        {
            try
            {
                Assert.IsTrue(driver.FindElement(By.XPath(contactPageTitle)).Displayed);
                Console.WriteLine("'Contact' page is displayed correctly.");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong. 'Contact' page is not displayed correctly.");
                throw;
            }
        }
    }
}
