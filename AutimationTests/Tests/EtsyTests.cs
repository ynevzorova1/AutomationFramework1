using EtsyAutimationTests.Pages;
using G2_AutomationFramework_1.Driver;
using G2_AutomationFramework_1.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace EtsyAutimationTests.Tests
{
    public class EtsyTests
    {
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = CustomDriver.Driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Minimize();
            driver.Navigate().GoToUrl("https://www.etsy.com/");
        }


        [TearDown]

        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void TestSearch()
        {
            var searchText = "Martin Boots";
            EtsyMainPage etsyMainPage = new EtsyMainPage(driver);
            etsyMainPage.searchArea.searchField.SetText(searchText);
            etsyMainPage.searchArea.searchButton.Click();

            EtsySearchPage etsySearchPage = new EtsySearchPage(driver);

            var texts = etsySearchPage.searchResultsTextItems;

            foreach (var textItem in texts)
            {
               Console.WriteLine(textItem.Text);
               Assert.True(textItem.Text.Contains(searchText));

            }

            driver.TakeScreenshot();
            driver.ExcuteJavaScript
        }

    }
}
