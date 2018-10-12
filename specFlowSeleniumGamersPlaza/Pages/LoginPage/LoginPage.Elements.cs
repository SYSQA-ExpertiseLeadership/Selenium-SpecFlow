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
    public partial class LoginPage : BasePage
    {
        internal static IWebElement usernameInputField { get { return driver.FindElement(By.CssSelector("#email")); } }
        internal static IWebElement passwordInputField { get { return driver.FindElement(By.Id("passwd")); } }
        internal static IWebElement loginButton { get { return driver.FindElement(By.Id("SubmitLogin")); } }
    }
}