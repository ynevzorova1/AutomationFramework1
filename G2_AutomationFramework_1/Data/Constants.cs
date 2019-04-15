using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G2_AutomationFramework_1.Data
{
    public class Constants
    {
        public string Path => ConfigurationManager.AppSettings["PathToScreenshotFolder"];

            IWebDriver Driver
        {
            get
            {
                if (ConfigurationManager.AppSettings["Browser"])== "Chrome")
            
            {
                    return new ChromeDriver
            }
            }
        }
    }
}
