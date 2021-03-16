using OpenQA.Selenium;
using QaWebTesterDemo.Support;

namespace QaWebTesterDemo.PageObjects
{
    public class HomePage
    {

        static IWebDriver Driver = DriverBoss.driver;
        
        //UI Elements
        private IWebElement Header => Driver.FindElement(By.XPath("//a[contains(text(),'Basic Java')]"));
        private IWebElement Headerw => Driver.FindElement(By.XPath("//headerd"));

        //Methods
        public HomePage ClickOnHeader()
        {
            DoAction.Click(Header);
            return new HomePage();
        }

    }

}
