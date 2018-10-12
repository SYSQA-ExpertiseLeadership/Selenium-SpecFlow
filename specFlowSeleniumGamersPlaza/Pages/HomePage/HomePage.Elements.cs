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
        static IWebElement SearchBar { get { return driver.FindElement(By.Id("search_query")); } }
        static IWebElement myaccount { get { return driver.FindElement(By.LinkText("Mijn account")); } }
    }
}