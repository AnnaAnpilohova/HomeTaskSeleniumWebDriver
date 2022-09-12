using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using HomeTaskSeleniumWebDriver;


namespace HomeTaskSeleniumWebDriver
{
    public class SearchPage : HomePage
    {
        public SearchPage(IWebDriver driver) : base(driver)
        {

        }
        private IWebElement btnSearchForAnImage => driver.FindElement(By.XPath("//a[@data-pid ='2']"));
        public void ClickbtnSearchForAnImage() => btnSearchForAnImage.Click();
    }
}
