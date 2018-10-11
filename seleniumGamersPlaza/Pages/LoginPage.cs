using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace seleniumGamersPlaza.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public static LoginPage enterUsername(String mailAddress)
        {
            IWebElement usernameInputField = driver.FindElement(By.CssSelector("#email"));
            usernameInputField.SendKeys(mailAddress);
            return new LoginPage(driver);
        }

        public static LoginPage enterPassword(String password)
        {
            IWebElement passwordInputField = driver.FindElement(By.Id("passwd"));
            passwordInputField.SendKeys(password);
            return new LoginPage(driver);
        }
        public static CategoryPage clickLoginButton()
        {
            IWebElement loginButton = driver.FindElement(By.Id("SubmitLogin"));
            loginButton.Click();
            return new CategoryPage(driver);
        }

        public static LoginPage verifyLogOutLinkPresented()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            Func<IWebDriver, bool> waitForElement = new Func<IWebDriver, bool>((IWebDriver driver) =>
            {
                driver.FindElement(By.LinkText("Afmelden"));
                return true;
            });
            wait.Until(waitForElement);
            return new LoginPage(driver);
        }
    }
}