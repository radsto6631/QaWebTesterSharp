using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace QaWebTesterDemo.Support
{
    class DoAction
    {
       
        public static void Click(IWebElement element)
        {
            try
            {
                element.Click();
            } catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
            
        }

        public static void WaitForElement(IWebElement element)
        {
            

        }


    }

}
