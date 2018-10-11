using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SpecFlow2.Steps
{
    [Binding]
    public class OrderFeatureSteps
    {
        public static IWebDriver driver;

        //[BeforeTestRun]
        [BeforeScenario]
        public static void SetupBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Window.FullScreen();
            driver.Url = "http://sbt.sysqa.nl/webshop/";
        }



        [Given(@"the user is on the homepage")]
        public void GivenTheUserIsOnTheHomepage()
        {
            IWebElement searchBar = driver.FindElement(By.Id("search_query"));
        }
        
        [When(@"the user navigates to the loginpage")]
        public void WhenTheUserNavigatesToTheLoginpage()
        {
            IWebElement myaccount = driver.FindElement(By.LinkText("Mijn account"));
            myaccount.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("email")));
        }
        
        [When(@"the user enters correct username")]
        public void WhenTheUserEntersCorrectUsername()
        {
            IWebElement usernameInputField = driver.FindElement(By.CssSelector("#email"));
            usernameInputField.SendKeys("selenium@sysqa.nl");
        }
        
        [When(@"the user enters correct password")]
        public void WhenTheUserEntersCorrectPassword()
        {
            IWebElement passwordInputField = driver.FindElement(By.Id("passwd"));
            passwordInputField.SendKeys("wachtwoord1");
        }
        
        [When(@"the user clicks on the login button")]
        public void WhenTheUserClicksOnTheLoginButton()
        {
            IWebElement loginButton = driver.FindElement(By.Id("SubmitLogin"));
            loginButton.Click();
        }
        
        [When(@"the user is succesfully logged in")]
        public void WhenTheUserIsSuccesfullyLoggedIn()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.LinkText("Afmelden")));
        }
        
        [When(@"the user navigates to Nintendo Wii Page")]
        public void WhenTheUserNavigatesToNintendoWiiPage()
        {
            IWebElement categorySection = driver.FindElement(By.Id("categories_block_left"));
            IWebElement nintendoWiiCategory = categorySection.FindElement(By.LinkText("Nintendo Wii"));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(nintendoWiiCategory));
            nintendoWiiCategory.Click();
        }
        
        [When(@"the user navigates to Music Games Page")]
        public void WhenTheUserNavigatesToMusicGamesPage()
        {
            IWebElement subCategorySection = driver.FindElement(By.Id("subcategories"));
            IWebElement MusicGamesSubCategory = subCategorySection.FindElement(By.LinkText("Music Games"));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(MusicGamesSubCategory));
            MusicGamesSubCategory.Click();
        }
        
        [When(@"the user clicks on order")]
        public void WhenTheUserClicksOnOrder()
        {
            IWebElement correctProduct = driver.FindElement(By.CssSelector(".ajax_block_product.first_item.item"));
            IWebElement correctOrderButton = correctProduct.FindElement(By.CssSelector(" .button.ajax_add_to_cart_button.exclusive"));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(correctOrderButton));
            correctOrderButton.Click();
        }
        
        [Then(@"Product is added to cart")]
        public void ThenProductIsAddedToCart()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("#cart_block_list [id^='cart_block_product']")));
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
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(guitarHero));
        }

        [AfterScenario]
        public static void TearDown()
        {
            driver.Close();
        }
    }
}
