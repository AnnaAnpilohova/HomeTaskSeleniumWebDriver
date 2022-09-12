using NUnit.Framework;
using System.Threading;
using HomeTaskSeleniumWebDriver;
using OpenQA.Selenium.Support.UI;
using System;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium;

namespace Tests
{
    public class SearchImageTest : BaseTest
    {
        [Test]
        public void SearchImage()
        {
            SearchPage search = new SearchPage(driver);
            search.ClickbtnSearchForAnImage();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SearchImagesPage image = new SearchImagesPage(driver);
            image.SendTextToField("cats");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            image.ClickBtnSearch();
            ImagesPage result = new ImagesPage(driver);
            Assert.IsTrue(result.CheckImage);
        }
    }
}
    
