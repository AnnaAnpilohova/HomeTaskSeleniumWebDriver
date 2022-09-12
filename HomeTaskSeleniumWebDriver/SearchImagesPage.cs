using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTaskSeleniumWebDriver
{
        public class SearchImagesPage : HomePage
        {
            public SearchImagesPage(IWebDriver driver) : base(driver)
            {

            }
        private IWebElement txtSearch => driver.FindElement(By.XPath("//input[@class = 'gLFyf gsfi']"));
        private IWebElement btnSearch => driver.FindElement(By.XPath("//button[@jsname = 'Tg7LZd']"));
        public void SendTextToField(string text) => txtSearch.SendKeys(text);
        public void ClickBtnSearch() => btnSearch.Click();
        }
}
