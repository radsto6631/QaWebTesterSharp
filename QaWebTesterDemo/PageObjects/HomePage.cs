using OpenQA.Selenium;
using QaWebTesterDemo.Support;

namespace QaWebTesterDemo.PageObjects
{
    public class HomePage
    {

        //UI Elements
        private By Header => By.XPath("//a[contains(text(),'Basic Java')]");

        //Methods
        public HomePage ClickOnHeader()
        {
            Header.ClickAndWait();
            return new HomePage();
        }




    }

}
