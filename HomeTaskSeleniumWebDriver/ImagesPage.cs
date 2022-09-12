using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using HomeTaskSeleniumWebDriver;
using System.Linq;

namespace HomeTaskSeleniumWebDriver
{
    public class ImagesPage : HomePage
    {
        public ImagesPage(IWebDriver driver) : base(driver)
        {

        }
        private readonly string image = "jpeg";
        public bool CheckImage => driver.PageSource.Contains(image);
    }
}
