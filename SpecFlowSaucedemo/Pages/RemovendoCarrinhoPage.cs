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
    public class RemovendoCarrinhoPage
    {
        public void AddToCart (IWebDriver driver)
        {
            WebDriverWait waiter = new(driver, new(0, 0, 10));
            var ClicaAddToCart = waiter.Until(ExpectedConditions.ElementToBeClickable(By.Id(RemovendoProdutoDoCarrinho.BtnAddToCart)));
            ClicaAddToCart.Click();
        }
        public void ClicaCarrinho(IWebDriver driver)
        {
            WebDriverWait waiter = new(driver, new(0, 0, 10));
            var ClicaCarrinho = waiter.Until(ExpectedConditions.ElementToBeClickable(By.XPath(RemovendoProdutoDoCarrinho.BtnCarrinho)));
            ClicaCarrinho.Click();
        }

        public void ClicaRemove(IWebDriver driver)
        {
            WebDriverWait waiter = new(driver, new(0, 0, 10));
            var ClicaRemove = waiter.Until(ExpectedConditions.ElementToBeClickable(By.Id(RemovendoProdutoDoCarrinho.BtnRemove)));
            ClicaRemove.Click();
        }

        public void ClicaContinueShopping(IWebDriver driver)
        {
            WebDriverWait waiter = new(driver, new(0, 0, 10));
            var ClicaContinueShopping = waiter.Until(ExpectedConditions.ElementToBeClickable(By.Id(RemovendoProdutoDoCarrinho.BtnContinueShopping)));
            ClicaContinueShopping.Click();
        }
    }
}
