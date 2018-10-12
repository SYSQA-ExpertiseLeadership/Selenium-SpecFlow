using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace specFlowSeleniumGamersPlaza.Pages
{
    public class BasePage
    {
        public static IWebDriver driver;
        public static WebDriverWait wait;

        protected BasePage(IWebDriver driver)
        {
            BasePage.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
    }
}
