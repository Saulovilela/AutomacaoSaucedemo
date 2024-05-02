using OpenQA.Selenium;
using SpecFlowProject1.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowSaucedemo.Pages
{
    public class ComprandoMochilaPage
    {
        public void ClicarImagemMochila(IWebDriver driver)
        {
            driver.FindElement(By.XPath(ComprandoMochilaElements.ImageMochila)).Click();
        }

        public void ClicarAddToCart(IWebDriver driver)
        {
            WebDriverWait waiter = new(driver, new(0, 0, 10));
            var clicaAddToCart = waiter.Until(ExpectedConditions.ElementToBeClickable(By.Id(ComprandoMochilaElements.AddtoCart)));
            clicaAddToCart.Click();
        }

        public void ClicaCarrinho(IWebDriver driver)
        {
            WebDriverWait waiter = new(driver, new(0, 0, 10));
            var clicaCarrinho = waiter.Until(ExpectedConditions.ElementToBeClickable(By.XPath(ComprandoMochilaElements.BtnCart)));
            clicaCarrinho.Click();
        }

        public void ClicaCheckout(IWebDriver driver)
        {
            WebDriverWait waiter = new(driver, new(0, 0, 10));
            var clicaCheckout = waiter.Until(ExpectedConditions.ElementToBeClickable(By.Id(ComprandoMochilaElements.BtnCheckout)));
            clicaCheckout.Click();
        }

        public void PreencheDados(string firstname, string lastname, string zipcode, IWebDriver driver)
        {
            driver.FindElement(By.Id(ComprandoMochilaElements.FirstName)).SendKeys(firstname);
            driver.FindElement(By.Id(ComprandoMochilaElements.LastName)).SendKeys(lastname);
            driver.FindElement(By.Id(ComprandoMochilaElements.ZipCode)).SendKeys(zipcode);
            driver.FindElement(By.Id(ComprandoMochilaElements.BtnContinue)).Click();
        }

        public void ClicaFinish(IWebDriver driver)
        {
            WebDriverWait waiter = new(driver, new(0, 0, 10));
            var btnFinish = waiter.Until(ExpectedConditions.ElementToBeClickable(By.Id(ComprandoMochilaElements.BtnFinish)));
            btnFinish.Click();
        }

        public bool ValidatePhrase(IWebDriver driver)
        {
            WebDriverWait waiter = new(driver, new(0,0,10));
            return waiter.Until(ExpectedConditions.ElementExists(By.XPath(ComprandoMochilaElements.ValidateXpath)))
                .Displayed;
        }
    }
}
