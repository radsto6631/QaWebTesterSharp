using QaWebTesterDemo.PageObjects;

namespace QaWebTesterDemo.Support
{
    class MyPages
    {

        public HomePage HomePage;
        public JavaPage JavaPage;

        public MyPages()
        {
            HomePage = new HomePage();
            JavaPage = new JavaPage();
        }
    }
}
