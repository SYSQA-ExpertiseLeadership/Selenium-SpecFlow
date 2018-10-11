using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace seleniumGamersPlaza.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        private static IWebElement findElementByStringInlist(IList<IWebElement> listOfElements, String searchString)
        {
            IWebElement finalElement = null;

            foreach(var el in listOfElements)
            {
                if (el.GetAttribute("text").Trim().Equals(searchString))
                {
                    finalElement = el;
                    break;
                }
            }
            return finalElement;
        }

        public static HomePage validateHomePage()
        {
            IWebElement searchBar = driver.FindElement(By.Id("search_query"));
            return new HomePage(driver);
        }

        public static LoginPage clickOnMyAccountLink()
        {
            IWebElement myaccount = driver.FindElement(By.LinkText("Mijn account"));
            myaccount.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("email")));
            return new LoginPage(driver);
        }

        public static CategoryPage selectCategoryAtSideBar(String category)
        {
            IList<IWebElement> listOfCategories = driver.FindElements(By.CssSelector("#categories_block_left .tree.dynamized>li"));
            IWebElement correctCategoryElement = findElementByStringInlist(listOfCategories, category);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(correctCategoryElement));
            correctCategoryElement.Click();
            return new CategoryPage(driver);
        }

        public static CategoryPage selectNintendoWiiCategory()
        {
            IWebElement categorySection = driver.FindElement(By.Id("categories_block_left"));
            IWebElement nintendoWiiCategory = categorySection.FindElement(By.LinkText("Nintendo Wii"));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(nintendoWiiCategory));
            nintendoWiiCategory.Click();
            return new CategoryPage(driver);
        }

        public static HomePage logOut()
        {
            IWebElement Afmelden = driver.FindElement(By.LinkText("Afmelden"));
		    if (Afmelden.Displayed && Afmelden.Enabled) {
			    Afmelden.Click();
		    } else {
			    Thread.Sleep(1000);
		    }

		    return new HomePage(driver);
	    }
    }
}
