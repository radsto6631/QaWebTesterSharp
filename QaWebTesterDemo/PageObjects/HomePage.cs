using OpenQA.Selenium;
using QaWebTesterDemo.Support;

namespace QaWebTesterDemo.Pages
{
    public class HomePage
    {
        
        //UI Elements
        private IWebElement Header => DriverBoss.driver.FindElement(By.XPath("//header"));

        //Methods
        public HomePage ClickOnHeader()
        {
            DoAction.Click(Header);
            return new HomePage();
        }

    }

}
