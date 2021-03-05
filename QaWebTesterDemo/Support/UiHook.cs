using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace QaWebTesterDemo
{
    [Binding]
    public sealed class UiHook
    {
        
        static IWebDriver _driver;
        private readonly IObjectContainer _objectContainer;

        public UiHook(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            options.AddArguments("--disable-extensions");
            options.AddAdditionalCapability("useAutomationExtension", false);
            options.AddExcludedArgument("enable-automation");
            _driver = new ChromeDriver(options);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Navigate().GoToUrl("http://www.qawebtester.com");
            _objectContainer.RegisterInstanceAs(_driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            var _driver = _objectContainer.Resolve<IWebDriver>();

            if (_driver == null) return;

            _driver.Close();
            _driver.Dispose();
            _driver.Quit();
        }
        
    }
}


