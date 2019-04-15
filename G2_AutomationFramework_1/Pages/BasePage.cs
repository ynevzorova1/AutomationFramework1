using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G2_AutomationFramework_1.Pages
{
    public class BasePage
    {
        public BasePage(IWebDriver driver) 
        {
            PageFactory.InitElements(driver, this);
        }
    }
}
