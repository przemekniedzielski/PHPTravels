using NUnit.Framework;
using Framework;
using static Framework.Pages.HomePage;
using static Framework.Pages.ContactPage;
using static Framework.Pages.AboutUsPage;
using static Framework.Helpers.MenuHelper;

namespace Tests
{
    public class BaseTests : Settings
    {
        [Test]
        public void CheckIfBaseElementsAreDisplayedCorrectlyTest()
        {
            CheckIfLogoIsDisplayed();
            CheckIfMainMenuOptionsAreDisplayed();
            CheckIfChangeCurrencyButtonIsDisplayed();
            CheckIfChangeLanguageButtonIsDisplayed();
        }

        [Test]
        public void CheckIfContactPageIsDisplayedCorrectlyTest()
        {
            GoToContactPage();
            CheckIfContactPageIsDisplayed();
        }

        [Test]
        public void CheckIfAboutUsPageIsDisplayedCorrectlyTest()
        {
            GoToAboutUsPage();
            CheckIfAboutUsPageIsDisplayed();
        }
    }
}
