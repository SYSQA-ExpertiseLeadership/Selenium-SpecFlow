using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace specFlowSeleniumGamersPlaza.Pages
{
    public partial class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public static HomePage ValidateHomePage(IWebDriver driver)
        {
            var validated = SearchBar != null;
            return new HomePage(driver);
        }


        public static HomePage ClickOnMyAccountLink() // Het kan dus ook een HomePage zijn, dan komt er een HomePage driver terug.
        {
            myaccount.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("email")));
            return new HomePage(driver);
        }

        /*
        public static LoginPage ClickOnMyAccountLink() // Waarom is dit een loginpage en niet de homepage?
        {
            IWebElement myaccount = driver.FindElement(By.LinkText("Mijn account"));
            myaccount.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("email")));
            return new LoginPage(driver);
        }
        */

        public static CategoryPage SelectNintendoWiiCategory()
        {

            IWebElement nintendoWiiCategory = categorySection.FindElement(By.LinkText("Nintendo Wii"));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(nintendoWiiCategory));
            nintendoWiiCategory.Click();
            return new CategoryPage(driver);
        }

        public static HomePage LogOut()
        {
            IWebElement Afmelden = driver.FindElement(By.LinkText("Afmelden"));
		    if (Afmelden.Displayed && Afmelden.Enabled) {
			    Afmelden.Click();
		    } else {
			    Thread.Sleep(1000);
		    }
            return new HomePage(driver);
        }
    }
}