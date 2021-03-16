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
       
        [BeforeScenario]
        public void BeforeScenario()
        {
            DriverBoss.GetInstance().Navigate().GoToUrl("https://www.qawebtester.com");
            DriverBoss.GetInstance().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            DriverBoss.CloseDriver();
        }


    }
}


