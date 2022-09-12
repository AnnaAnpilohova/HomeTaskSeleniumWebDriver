using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTaskSeleniumWebDriver
{
    public static  class WaitUntil
    {
        public static void ShouldLocate(IWebDriver webdriver, string location)
        {
            try
            {
                new WebDriverWait(webdriver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.UrlContains(location));
            }
            catch (WebDriverTimeoutException ex)
            {
                throw new NotFoundException($"Cannot find out that app in specific location: {location}", ex);
            }
        }
    }
}
