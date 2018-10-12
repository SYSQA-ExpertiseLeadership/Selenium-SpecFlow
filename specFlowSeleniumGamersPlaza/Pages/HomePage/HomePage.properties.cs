using OpenQA.Selenium.Support.UI;
using System;

namespace specFlowSeleniumGamersPlaza.Pages
{
    public partial class HomePage : BasePage
    {
        static WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
    }
}