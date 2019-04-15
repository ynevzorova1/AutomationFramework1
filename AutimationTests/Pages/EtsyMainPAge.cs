using G2_AutomationFramework_1.Pages;
using OpenQA.Selenium;

namespace EtsyAutimationTests.Pages
{
    class EtsyMainPage : BasePage
    {
        public EtsyMainPage(IWebDriver driver) : base(driver)
        {
            searchArea = new SearchArea(driver);
        }

        public SearchArea searchArea;
    }
}
