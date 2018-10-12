using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using static OpenQA.Selenium.Support.UI.ExpectedConditions;

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
            Assert.IsTrue(validated);
            return new HomePage(driver);
        }


        public static HomePage ClickOnMyAccountLink() // Het kan dus ook een HomePage zijn, dan komt er een HomePage driver terug.
        {
            MyAccount.Click();

            wait.Until(ElementIsVisible(By.Id("email"))); // volgens mij hoeft dit niet en de methode is obsolete 
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
            wait.Until(ElementToBeClickable(NintendoWiiCategory));

            NintendoWiiCategory.Click();

            return new CategoryPage(driver);
        }

        public static HomePage LogOut()
        {
            var afmelden = Afmelden;
		    if (afmelden.Displayed && afmelden.Enabled) {
			    afmelden.Click();
		    } else {
			    Thread.Sleep(1000); // dit kan concreeter
		    }
            return new HomePage(driver);
        }
    }
}