using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using static SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace specFlowSeleniumGamersPlaza.Pages
{
    public partial class CategoryPage : BasePage
    {
        public CategoryPage(IWebDriver driver) : base(driver)
        {
        }

        public static CategoryPage SelectMusicGamesSubCatagory()
        {
            wait.Until(ElementToBeClickable(MusicGamesSubCategory));
            MusicGamesSubCategory.Click();
            return new CategoryPage(driver);
        }

        public static CategoryPage AddProductToCart()
        { 
            wait.Until(ElementToBeClickable(CorrectOrderButton));
            CorrectOrderButton.Click();
            return new CategoryPage(driver);
        }

        public static CategoryPage VerifyProductPresentInCart()
        {
            wait.Until(ElementIsVisible(By.CssSelector("#cart_block_list [id^='cart_block_product']")));

            try
            {
                Guitarhero.ToString();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Element met naam 'Guitar Hero' is niet gevonden");
            }
            wait.Until(ElementToBeClickable(Guitarhero));
            return new CategoryPage(driver);

        }
    }
}
