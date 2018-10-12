using OpenQA.Selenium;

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