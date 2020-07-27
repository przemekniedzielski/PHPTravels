using System;
using NUnit.Framework;
using OpenQA.Selenium;
using static Framework.Helpers.MenuHelper;

namespace Framework.Pages
{
    public class HomePage : Settings
    {
        //Elements
        private readonly static string logo = "//div[@class='header-top']//div[contains(@class, 'col-md-4 col-2 o2')]//img";
        private readonly static string changeCurrencyButton = "//div[@class='mini-menu']//div[@class='dropdown dropdown-currency']";

        //Methods

        //Assertions
        public static void CheckIfLogoIsDisplayed()
        {
            try
            {
                Assert.IsTrue(driver.FindElement(By.XPath(logo)).Displayed);
                Console.WriteLine("Logo on page is displayed.");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong. Logo is not displayed correctly.");
                throw;
            }
        }

        public static void CheckIfChangeCurrencyButtonIsDisplayed()
        {
            try
            {
                Assert.IsTrue(driver.FindElement(By.XPath(changeCurrencyButton)).Displayed);
                Console.WriteLine("Logo on page is displayed.");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong. Logo is not displayed correctly.");
                throw;
            }
        }

        public static void CheckIfMainMenuOptionsAreDisplayed()
        {
            try
            {
                Assert.IsTrue(driver.FindElement(By.XPath(homeButton)).Displayed);
                Assert.IsTrue(driver.FindElement(By.XPath(companyButton)).Displayed);
                driver.FindElement(By.XPath(companyButton)).Click();
                Assert.IsTrue(driver.FindElement(By.XPath(contactButton)).Displayed);
                Assert.IsTrue(driver.FindElement(By.XPath(aboutUsButton)).Displayed);
                Console.WriteLine("Main menu options are displayed correctly.");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong. Main menu options are not displayed correctly.");
                throw;
            }
        }
    }
}
