using OpenQA.Selenium;
using QaWebTesterDemo.Support;

namespace QaWebTesterDemo.Pages
{
    public class HomePage
    {

        static IWebDriver Driver = DriverBoss.driver;
        
        //UI Elements
        private IWebElement Header => Driver.FindElement(By.XPath("//header"));

        //Methods
        public HomePage ClickOnHeader()
        {
            DoAction.Click(Header);
            return new HomePage();
        }

    }

}
