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
        }

        [AfterScenario]
        public void AfterScenario()
        {
            DriverBoss.CloseDriver();
        }


    }
}


