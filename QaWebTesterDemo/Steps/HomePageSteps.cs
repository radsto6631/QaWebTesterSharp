using OpenQA.Selenium;
using QaWebTesterDemo.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace QaWebTesterDemo.Steps
{

    [Binding]
    class HomePageSteps
    {

        private readonly HomePage _homePage;

        public HomePageSteps(HomePage page) => _homePage = page;
        

        [Given(@"Navigate to Site")]
        public void GivenNavigateToSite()
        {
            _homePage.ClickOnHeader();
        }


    }
}
