using OpenQA.Selenium;
using QaWebTesterDemo.Support;

namespace QaWebTesterDemo.Pages
{
    public class HomePage
    {

        private readonly IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        //UI Elements
        public IWebElement Header => _driver.FindElement(By.XPath("//header7"));

        //Methods
        public void ClickOnHeader()
        {
            DoAction.Click(Header);
        }


    }

}
