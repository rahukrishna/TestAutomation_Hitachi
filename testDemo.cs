using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTest.Drivers;
using SeleniumTest.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTest
{
    public class testDemo
    {

        [SetUp]
        public void startBrowser()
        {
            Driver.initializeWeDriver();

        }

        [Test]
        public void test()
        {

            HomePage.launchUrl();
           HomePage.clickContactUs();
            HomePage.validateLocation();


        }
        [TearDown]
        public void tearDownBrowser()
        {
            Driver.closeBrowser();
        }

    }
}
