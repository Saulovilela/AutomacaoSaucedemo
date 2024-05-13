using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using SpecFlowSaucedemo.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecFlowProject1.Elements;

namespace SpecFlowSaucedemo.Pages
{
    public class NãoInserindoValorCepPage
    {
        public void AddToCart(IWebDriver driver)
        {
            WebDriverWait waiter = new(driver, new(0, 0, 10));
            var ClicaAddToCart = waiter.Until(ExpectedConditions.ElementToBeClickable(By.Id(NãoInserindoValorCep.BtnAddToCart)));
            ClicaAddToCart.Click();
        }
        public void ClicaCarrinho(IWebDriver driver)
        {
            WebDriverWait waiter = new(driver, new(0, 0, 10));
            var ClicaCarrinho = waiter.Until(ExpectedConditions.ElementToBeClickable(By.XPath(NãoInserindoValorCep.BtnCarrinho)));
            ClicaCarrinho.Click();
        }

        public void ClicaCheckout(IWebDriver driver)
        {
            WebDriverWait waiter = new(driver, new(0, 0, 10));
            var clicaCheckout = waiter.Until(ExpectedConditions.ElementToBeClickable(By.Id(NãoInserindoValorCep.BtnCheckout)));
            clicaCheckout.Click();
        }

        public void PreencheCamposObrigatorios(string firstname, string lastname, string zipcode, IWebDriver driver)
        {
            driver.FindElement(By.Id(NãoInserindoValorCep.FirstName)).SendKeys(firstname);
            driver.FindElement(By.Id(NãoInserindoValorCep.LastName)).SendKeys(lastname);
            driver.FindElement(By.Id(NãoInserindoValorCep.ZipCode)).SendKeys(zipcode); 

        }

        public void ClicaContinue(IWebDriver driver)
        {
            WebDriverWait waiter = new(driver, new(0, 0, 10));
            var clicaContinue = waiter.Until(ExpectedConditions.ElementToBeClickable(By.Id(NãoInserindoValorCep.BtnContinue)));
            clicaContinue.Click();
        }

        public bool MensagemDeErro(IWebDriver driver)
        {
            WebDriverWait waiter = new(driver, new(0, 0, 10));
            return waiter.Until(ExpectedConditions.ElementIsVisible(By.XPath(NãoInserindoValorCep.MsgError)))
            .Displayed;
        }

    }

}

