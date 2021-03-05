using OpenQA.Selenium;
using System;
using System.Threading.Tasks;

namespace QaWebTesterDemo.Support
{
    class Await
    {
        public static async Task WaitForElementAsync(IWebElement element)
        {
            await With(100, 200, true, () => element.Displayed);
        }

        private static async Task With(
            int pollDeley,
            int pollIntervall,
            bool ignoreException,
            Func<bool> until)
        {
            await Task.Delay(pollDeley);

            var loop = true;

            while (loop)
            {
                try
                {
                    loop = !until();
                    if (!loop) break;
                    await Task.Delay(pollIntervall);
                }
                catch (Exception ex)
                {
                    if (!ignoreException) throw;
                }
            }
        }


    }
}
