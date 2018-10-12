using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using BoDi;
using static SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace specFlowSeleniumGamersPlaza.Pages
{
    public partial class LoginPage : BasePage
    { 
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public static LoginPage EnterUsername(String mailAddress)
        {
            usernameInputField.SendKeys(mailAddress);
            return new LoginPage(driver);
        }

        public static LoginPage EnterPassword(String password)
        {
            passwordInputField.SendKeys(password);
            return new LoginPage(driver);
        }
        public static CategoryPage ClickLoginButton()
        {
            loginButton.Click();
            return new CategoryPage(driver);
        }

        public static LoginPage VerifyLogOutLinkPresented()
        {
            wait.Until(ElementIsVisible(By.LinkText("Afmelden")));
            return new LoginPage(driver);
        }
    }
}