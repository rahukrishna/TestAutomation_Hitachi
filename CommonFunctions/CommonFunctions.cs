using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumTest.Drivers;

namespace SeleniumTest.CommonFunctions
{
    public  class CommonMethods
    {
        public static IWebElement getElement(string Locator, string locatorType="xpath")
        {
            IWebElement element = null;
            switch (locatorType)
            {
                case "xpath":
                    element = Driver.driver.FindElement(By.XPath("locator"));
                    break;
                case "css":
                    element = Driver.driver.FindElement(By.CssSelector("locator"));
                    break;
                
            }
            return element;

        }
        public static IWebElement getElement(string Locator)
        {
            IWebElement element = null;
            
                    element = Driver.driver.FindElement(By.XPath(Locator));
            
            return element;

        }

        public static void type (string text,string locator )
        {
            getElement(locator).Clear();
            getElement(locator).SendKeys(text);
        }
        public static void click (string  locator)
        {
            getElement(locator).Click();
        }

        public static string getText(string locator)
        {
            return getElement(locator).Text;
        }
    }
}
