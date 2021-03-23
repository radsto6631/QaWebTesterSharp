using OpenQA.Selenium;
using QaWebTesterDemo.Support;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace QaWebTesterDemo.PageObjects
{
    public class JavaPage
    {
        static IWebDriver Driver = DriverBoss.driver;

        //UI Elements
        private By JavaTypes => By.XPath("//a[contains(text(),'Data Types')]");

        //Methods
        public JavaPage ClickOnSomething()
        {
            Thread.Sleep(5000);
            JavaTypes.ClickAndWait();
            return new JavaPage();
        }

    }
}
