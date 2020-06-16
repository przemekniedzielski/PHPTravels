using NUnit.Framework;
using Framework;
using static Framework.Pages.HomePage;

namespace Tests
{
    public class BaseTests : Settings
    {
        [Test]
        public void CheckIfLogoIsDisplayedCorrectlyTest()
        {
            CheckIfLogoIsDisplayed();
        }
    }
}
