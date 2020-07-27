using OpenQA.Selenium;
using System;

namespace Framework.Helpers
{
    public class MenuHelper : Settings
    {
        public readonly static string homeButton = "//div[@class='navbar-wrapper']//a[contains(@title, 'home')]";
        public readonly static string visaButton = "//div[@class='navbar-wrapper']//a[contains(text(), 'Visa')]";
        public readonly static string companyButton = "//div[@class='navbar-wrapper']//a[contains(text(), 'company')]";
        public readonly static string contactButton = "//div[@class='navbar-wrapper']//a[contains(text(), 'company')]//following-sibling::ul//a[contains(text(), 'Contact')]";
        public readonly static string aboutUsButton = "//div[@class='navbar-wrapper']//a[contains(text(), 'company')]//following-sibling::ul//a[contains(text(), 'About Us')]";

        public static void GoToHomePage()
        {
            driver.FindElement(By.XPath(homeButton)).Click();
            Console.WriteLine("Clicked 'Home' button.");
        }

        public static void GoToContactPage()
        {
            driver.FindElement(By.XPath(companyButton)).Click();
            driver.FindElement(By.XPath(contactButton)).Click();
            Console.WriteLine("Clicked 'Contact' button.");
        }

        public static void GoToAboutUsPage()
        {
            driver.FindElement(By.XPath(companyButton)).Click();
            driver.FindElement(By.XPath(aboutUsButton)).Click();
            Console.WriteLine("Clicked 'About Us' button.");
        }
    }
}