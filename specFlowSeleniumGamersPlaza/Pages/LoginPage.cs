using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using BoDi;

namespace specFlowSeleniumGamersPlaza.Pages
{
    public class LoginPage : BasePage
    {

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public static LoginPage EnterUsername(String mailAddress)
        {
            IWebElement usernameInputField = driver.FindElement(By.CssSelector("#email"));
            usernameInputField.SendKeys(mailAddress);
            return new LoginPage(driver);
        }

        public static LoginPage EnterPassword(String password)
        {
            IWebElement passwordInputField = driver.FindElement(By.Id("passwd"));
            passwordInputField.SendKeys(password);
            return new LoginPage(driver);
        }
        public static CategoryPage ClickLoginButton()
        {
            IWebElement loginButton = driver.FindElement(By.Id("SubmitLogin"));
            loginButton.Click();
            return new CategoryPage(driver);
        }

        public static LoginPage VerifyLogOutLinkPresented()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.LinkText("Afmelden")));
            return new LoginPage(driver);
        }
    }
}