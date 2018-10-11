using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using SeleniumExtras.WaitHelpers;
using System.Threading;

namespace seleniumGamersPlaza.Pages
{
    public class CategoryPage : BasePage
    {
        public CategoryPage(IWebDriver driver) : base(driver)
        {
        }

        public static CategoryPage selectMusicGamesSubCatagory()
        {
            IWebElement subCategorySection = driver.FindElement(By.Id("subcategories"));
            IWebElement MusicGamesSubCategory = subCategorySection.FindElement(By.LinkText("Music Games"));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(MusicGamesSubCategory));
            MusicGamesSubCategory.Click();
            return new CategoryPage(driver);
        }

        public static CategoryPage addProductToCart()
        {
            IWebElement correctProduct = driver.FindElement(By.CssSelector(".ajax_block_product.first_item.item"));
            IWebElement correctOrderButton = correctProduct.FindElement(By.CssSelector(" .button.ajax_add_to_cart_button.exclusive"));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(correctOrderButton));
            correctOrderButton.Click();
            return new CategoryPage(driver);
        }

        public static CategoryPage verifyProductPresentInCart()
        {
            IWebElement shoppingCartProducts = driver.FindElement(By.CssSelector("#cart_block_list [id^='cart_block_product']"));
            IWebElement guitarHero = null;
            try
            {
                guitarHero = shoppingCartProducts.FindElement(By.LinkText("Guitar Hero..."));
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Element met naam 'Guitar Hero' is niet gevonden");
            }
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(guitarHero));
            return new CategoryPage(driver);
        }
    }
}
