using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G2_AutomationFramework_1.Utils
{
    public static class WebDriverExtensions
    {
        const string path = "C:/Users/scren.png";

        public static void TakeScreenshot (this IWebDriver driver,
            string pathToFile =path,
            ScreenshotImageFormat format = ScreenshotImageFormat.Png)
        {
            ((ITakesScreenshot)driver)
                .GetScreenshot()
                .SaveAsFile(pathToFile, format);

            //ConfigurationSettings.AppSettings["PathToScreenshotFolder"];
        }
        public static void ExcuteJavaScript(this IWebDriver driver,string jsScript)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("some JS script", jsScript);
        }
    }
}
