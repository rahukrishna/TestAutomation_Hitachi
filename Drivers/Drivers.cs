using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.Drivers
{
    public  class Driver
    {
        public static IWebDriver driver;

        public static void initializeWeDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        public static void closeBrowser()
        {
            driver.Quit();
        }
    }
}
