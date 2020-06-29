using OpenQA.Selenium;
using System;
using static Framework.Helpers.WaitHelper;

namespace Framework.Helpers
{
    public class MenuHelper : Settings
    {
        private readonly static string homeButton = "//div[@class='navbar-wrapper']//a[contains(@title, 'home')]";
        private readonly static string companyButton = "//div[@class='navbar-wrapper']//a[contains(text(), 'company')]";
        private readonly static string contactButton = "//div[@class='navbar-wrapper']//a[contains(text(), 'company')]//following-sibling::ul//a[contains(text(), 'Contact')]";
        private readonly static string aboutUsButton = "//div[@class='navbar-wrapper']//a[contains(text(), 'company')]//following-sibling::ul//a[contains(text(), 'About Us')]";


        public static void GoToHomePage()
        {
            driver.FindElement(By.XPath(homeButton)).Click();
            Console.WriteLine("Clicked 'Home' button.");
        }

        public static void GoToContactPage()
        {
            driver.FindElement(By.XPath(companyButton)).Click();
            WaitUntilElementIsDisplayed(driver.FindElement(By.XPath(contactButton)));
            driver.FindElement(By.XPath(contactButton)).Click();
            Console.WriteLine("Clicked 'Contact' button.");
        }

        public static void GoToAboutUsPage()
        {
            driver.FindElement(By.XPath(companyButton)).Click();
            WaitUntilElementIsDisplayed(driver.FindElement(By.XPath(aboutUsButton)));
            driver.FindElement(By.XPath(aboutUsButton)).Click();
            Console.WriteLine("Clicked 'About Us' button.");
        }
    }
}