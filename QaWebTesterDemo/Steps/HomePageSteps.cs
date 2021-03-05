using QaWebTesterDemo.Pages;
using TechTalk.SpecFlow;

namespace QaWebTesterDemo.Steps
{

    [Binding]
    class HomePageSteps
    {
        

        [Given(@"Navigate to Site")]
        public void GivenNavigateToSite()
        {
            new HomePage().ClickOnHeader();
        }

    }
}
