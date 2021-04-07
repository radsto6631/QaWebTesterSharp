using QaWebTesterDemo.Support;
using TechTalk.SpecFlow;

namespace QaWebTesterDemo.Steps
{

    [Binding]
    class HomePageSteps : MyPages
    {
        

        [Given(@"Navigate to Site")]
        public void GivenNavigateToSite()
        {
           HomePage.ClickOnHeader();
        }

        [Then(@"I click on ble ble")]
        public void ThenIClickOnBleBle()
        {
            JavaPage.ClickOnSomething();
        }

        [Given(@"Navigate to Site (.*)")]
        public void GivenNavigateToSite(string url)
        {
            DriverBoss.GetInstance().Navigate().GoToUrl("https://"+url);
        }



    }
}
