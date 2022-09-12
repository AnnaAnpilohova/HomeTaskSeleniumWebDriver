using OpenQA.Selenium;
using System;

namespace HomeTaskSeleniumWebDriver
{
    public class HomePage
    {
        protected IWebDriver driver;
        public HomePage(IWebDriver webdriver)
        {
            driver = webdriver;
        }
    }
}
