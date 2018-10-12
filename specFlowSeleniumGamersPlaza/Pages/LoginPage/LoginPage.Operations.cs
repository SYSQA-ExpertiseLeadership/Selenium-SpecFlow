using OpenQA.Selenium;
using System;
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
            UserNameInputField.SendKeys(mailAddress);
            return new LoginPage(driver);
        }

        public static LoginPage EnterPassword(String password)
        {
            PasswordInputField.SendKeys(password);
            return new LoginPage(driver);
        }
        public static CategoryPage ClickLoginButton()
        {
            LoginButton.Click();
            return new CategoryPage(driver);
        }

        public static LoginPage VerifyLogOutLinkPresented()
        {
            wait.Until(ElementIsVisible(By.LinkText("Afmelden")));
            return new LoginPage(driver);
        }
    }
}