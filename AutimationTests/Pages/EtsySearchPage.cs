using G2_AutomationFramework_1.Pages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtsyAutimationTests.Pages
{
    class EtsySearchPage : BasePage
    {
        public EtsySearchPage(IWebDriver driver) : base(driver)
        {

        }

        [FindsBy(How = How.XPath, Using = "//*[contains(@class,'v2-listing-card__info')and not(contains(@class, 'flex'))]//h2")]
        public IList<IWebElement> searchResultsTextItems;
    }
}
