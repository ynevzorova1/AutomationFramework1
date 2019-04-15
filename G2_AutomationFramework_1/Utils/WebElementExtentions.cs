using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G2_AutomationFramework_1.Utils
{
   public static class WebElementExtentions
    {
public static void SetText(this IWebElement element, string text)
        {
            element.SendKeys(text);
        }

        public static void SetDropdownOptionsByText(this IWebElement element,string text)
        {
            new SelectElement(element).SelectByText(text);
        }

    }
}
