using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Framework
{
    public class Settings
    {
        protected static IWebDriver driver { get; set; }

        public static string url = "https://www.phptravels.net/";

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Dispose();
        }
    }
}
