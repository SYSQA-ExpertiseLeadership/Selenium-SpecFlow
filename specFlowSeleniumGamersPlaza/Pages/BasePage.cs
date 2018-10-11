using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using BoDi;


namespace specFlowSeleniumGamersPlaza.Pages
{
    public class BasePage
    {
        public static IWebDriver driver;
        public BasePage(IWebDriver driver)
        {
            BasePage.driver = driver;
        }
    }
}
