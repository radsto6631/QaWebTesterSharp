using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace QaWebTesterDemo.Support
{
    class DoAction
    {

        public static void WaitForElement(IWebElement element)
        {
            _ = Await.WaitForElementAsync(element);
        }

        public static void Click(IWebElement element)
        {
            try
            {
                WaitForElement(element);
                Highlight(element);
                element.Click();
            } catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        public static void Highlight(IWebElement element)
        {
            ((IJavaScriptExecutor)DriverBoss.driver).ExecuteScript("arguments[0].style.border='3px dotted blue'", element);
        }


    }

}
