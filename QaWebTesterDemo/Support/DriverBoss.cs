using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace QaWebTesterDemo
{
    public class DriverBoss
    {
        public static IWebDriver driver;

        public static IWebDriver GetInstance()
        {
            if (driver == null)
            {
                driver = SetUpWebDriver();
            }
            return driver;
        }

        public static void CloseDriver()
        {
            if (driver != null)
            {
                driver.Manage().Cookies.DeleteAllCookies();
                driver.Close();
                driver.Quit();
                driver.Dispose();
                driver = null;
            }
        }

        private static IWebDriver SetUpWebDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            options.AddArguments("--disable-extensions");
            options.AddAdditionalCapability("useAutomationExtension", false);
            options.AddExcludedArgument("enable-automation");
            driver = new ChromeDriver(options);
            return driver;
        }
    }
}