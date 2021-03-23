using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace QaWebTesterDemo.Support
{
    public static class DoAction
    {

        public static void ClickAndWait(this By element)
        {
            try
            {
                DriverBoss.driver.FindElement(element).Click();
                Highlight(element);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }


        public static void Highlight(this By element)
        {
            ((IJavaScriptExecutor)DriverBoss.driver).ExecuteScript("arguments[0].style.border='3px dotted blue'", DriverBoss.driver.FindElement(element));
        }


    }

}
