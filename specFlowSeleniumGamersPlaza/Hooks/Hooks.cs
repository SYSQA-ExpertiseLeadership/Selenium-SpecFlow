using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using BoDi;

namespace specFlowSeleniumGamersPlaza.Hooks
{
    [Binding]
    public class Hooks1
    {

        public static IWebDriver driver;

        //[BeforeTestRun]
        [BeforeScenario]
        public static void SetupBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Window.FullScreen();
            driver.Url = "http://sbt.sysqa.nl/webshop/";
        }

        [AfterScenario]
        public static void TearDown()
        {
            driver.Close();
        }
    }
}