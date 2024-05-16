using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SpecFlowSaucedemo.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowSaucedemo.Pages
{
    public class VerificaSeLevaParaPaginaLinkedinPage
    {
        public void ClicaBtnLinkedin(IWebDriver driver)
        {
            WebDriverWait waiter = new(driver, new(0, 0, 10));
            var BtnLinkedin = waiter.Until(ExpectedConditions.ElementToBeClickable(By.XPath(VerificaSeLevaParaPaginaLinkedin.BtnLinkedin)));
            BtnLinkedin.Click();
        }
    }
}
