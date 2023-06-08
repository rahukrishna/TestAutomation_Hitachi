using NUnit.Framework;
using SeleniumTest.CommonFunctions;
using SeleniumTest.Data;
using SeleniumTest.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.Pages
{
    public class HomePage
    {
        public static string contactUsBtn = "//ul[@class='menu contact-item']/li/a";
        public static string location1Txt = "//div[@class='container']/div[2]/p[1]/a";

        public static void launchUrl()
        {
            Driver.driver.Navigate().GoToUrl(TestData.getHomePageUrl());
        }
        public static void clickContactUs()
        {
            CommonMethods.click(contactUsBtn);
        }

        public static void validateLocation ()
        {
            Assert.AreEqual("Irvine, United States", CommonMethods.getText(location1Txt));
        }

    }
}
