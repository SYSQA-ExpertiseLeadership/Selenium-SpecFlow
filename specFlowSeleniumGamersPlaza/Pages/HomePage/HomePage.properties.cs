using OpenQA.Selenium.Support.UI;
using System;

namespace specFlowSeleniumGamersPlaza.Pages
{
    public partial class HomePage : BasePage
    {
        public static bool AfmeldenWerkt { get { return Afmelden.Displayed && Afmelden.Enabled; } }
    }
}