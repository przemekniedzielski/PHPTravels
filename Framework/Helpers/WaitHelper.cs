using System;

namespace Framework.Helpers
{
    public class WaitHelper : Settings
    {
        public static void EnableImplicitWait()
        {
            try
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(waitTime);
                Console.WriteLine("Implicit Wait was enabled.");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong.");
                throw;
            }
        }
    }
}
