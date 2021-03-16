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
        private IWebElement JavaTypes => Driver.FindElement(By.XPath("//a[contains(text(),'Data Types')]"));

        //Methods
        public JavaPage ClickOnSomething()
        {
           // Thread.Sleep(5000);
            DoAction.Click(JavaTypes);
            return new JavaPage();
        }

    }
}
