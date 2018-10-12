using OpenQA.Selenium;

namespace specFlowSeleniumGamersPlaza.Pages
{
    public partial class LoginPage : BasePage
    {
        internal static IWebElement UserNameInputField { get { return driver.FindElement(By.CssSelector("#email")); } }
        internal static IWebElement PasswordInputField { get { return driver.FindElement(By.Id("passwd")); } }
        internal static IWebElement LoginButton { get { return driver.FindElement(By.Id("SubmitLogin")); } }
    }
}