using OpenQA.Selenium;
using specFlowSeleniumGamersPlaza.Hooks;
using specFlowSeleniumGamersPlaza.Pages;
using TechTalk.SpecFlow;


namespace specFlowSeleniumGamersPlaza.Steps
{
    [Binding]
    public class LoginSteps
    {
        public IWebDriver driver;
        public LoginSteps()
        {
            driver = Hooks1.driver;
        }

        [Given(@"the user is on the homepage")]
        public void GivenTheUserIsOnTheHomepage()
        {
            // Waarom moet ik hier de driver meesturen?
            // Verderop is het niet nodig en ook voor de andere pagina's is het niet nodig.
            // Misschien dat Rianne het weet
            // PageFactory.InitElements(driver, typeof(HomePage)); // Dit blijkt ook niet noodzakelijk
            HomePage.ValidateHomePage(driver);
        }

        [When(@"the user navigates to the loginpage")]
        public void WhenTheUserNavigatesToTheLoginpage()
        {
            HomePage.ClickOnMyAccountLink();
        }

        [When(@"the user enters correct username")]
        public void WhenTheUserEntersCorrectUsername()
        {
            LoginPage.EnterUsername("selenium@sysqa.nl");
        }

        [When(@"the user enters correct password")]
        public void WhenTheUserEntersCorrectPassword()
        {
            LoginPage.EnterPassword("wachtwoord1");
        }

        [When(@"the user clicks on the login button")]
        public void WhenTheUserClicksOnTheLoginButton()
        {
            LoginPage.ClickLoginButton();
        }

        [When(@"the user is succesfully logged in")]
        public void ThenTheUserIsSuccesfullyLoggedIn()
        {
            LoginPage.VerifyLogOutLinkPresented();
        }

        [When(@"the user navigates to Nintendo Wii Page")]
        public void WhenTheUserNavigatesToNintendoWiiPage()
        {
            HomePage.SelectNintendoWiiCategory();
        }

        [When(@"the user navigates to Music Games Page")]
        public void WhenTheUserNavigatesToMusicGamesPage()
        {
            CategoryPage.SelectMusicGamesSubCatagory();
        }

        [When(@"the user clicks on order")]
        public void WhenTheUserClicksOnOrder()
        {
            CategoryPage.AddProductToCart();
        }

        [Then(@"Product is added to cart")]
        public void ThenProductIsAddedToCart()
        {
            CategoryPage.VerifyProductPresentInCart();
        }
    }
}
