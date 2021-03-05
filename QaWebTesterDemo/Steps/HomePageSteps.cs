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

    }
}
