using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using specFlowSeleniumGamersPlaza.Pages;
using BoDi;

namespace specFlowSeleniumGamersPlaza.Steps
{
    [Binding]
    public class AddToCartSteps
    {
        /*
        private IObjectContainer objectContainer;
        IWebDriver driver;
        public AddToCartSteps(IObjectContainer objectContainer)
        {
            this.driver = objectContainer.Resolve<IWebDriver>();
        }
        */
        [Given(@"the user is logged in")]
        public void GivenTheUserIsLoggedIn()
        {
            //LoginPage login = new LoginPage(objectContainer);
            //login.VerifyLogOutLinkPresented();
            ScenarioContext.Current.Set(LoginPage.VerifyLogOutLinkPresented());
        }
        
        [When(@"the user navigates to Nintendo Wii Page")]
        public void WhenTheUserNavigatesToNintendoWiiPage()
        {
            //HomePage thuis = new HomePage(objectContainer);
            //thuis.SelectNintendoWiiCategory();
            ScenarioContext.Current.Set(HomePage.SelectNintendoWiiCategory());
        }
        
        [When(@"the user navigates to Music Games Page")]
        public void WhenTheUserNavigatesToMusicGamesPage()
        {
            //CategoryPage categorie = new CategoryPage(objectContainer);
            //categorie.SelectMusicGamesSubCatagory();
            ScenarioContext.Current.Set(CategoryPage.SelectMusicGamesSubCatagory());
        }
        
        [When(@"the user clicks on order")]
        public void WhenTheUserClicksOnOrder()
        {
            //CategoryPage categorie = new CategoryPage(objectContainer);
            //categorie.AddProductToCart();
            ScenarioContext.Current.Set(CategoryPage.AddProductToCart());
        }
        
        [Then(@"Product is added to cart")]
        public void ThenProductIsAddedToCart()
        {
            //CategoryPage categorie = new CategoryPage(objectContainer);
            //categorie.VerifyProductPresentInCart();
            ScenarioContext.Current.Set(CategoryPage.VerifyProductPresentInCart());
        }
    }
}
