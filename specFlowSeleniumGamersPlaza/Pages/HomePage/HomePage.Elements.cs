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
        public static IWebElement SearchBar { get { return driver.FindElement(By.Id("search_query")); } }
        public static IWebElement MyAccount { get { return driver.FindElement(By.LinkText("Mijn account")); } }
        public static IWebElement EmailBar { get { return driver.FindElement(By.Id("email")); } }
        public static IWebElement CategorySection { get { return driver.FindElement(By.Id("categories_block_left")); } }
        public static IWebElement NintendoWiiCategory { get { return CategorySection.FindElement(By.LinkText("Nintendo Wii")); } }
        public static IWebElement Afmelden { get { return driver.FindElement(By.LinkText("Afmelden")); } }
    }
}