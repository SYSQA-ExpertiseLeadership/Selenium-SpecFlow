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
        static IWebElement MyAccount { get { return driver.FindElement(By.LinkText("Mijn account")); } }
        static IWebElement EmailBar { get { return driver.FindElement(By.Id("email")); } }
        static IWebElement CategorySection { get { return driver.FindElement(By.Id("categories_block_left")); } }
        static IWebElement NintendoWiiCategory { get { return CategorySection.FindElement(By.LinkText("Nintendo Wii")); } }
        static IWebElement Afmelden { get { return driver.FindElement(By.LinkText("Afmelden")); } }
    }
}