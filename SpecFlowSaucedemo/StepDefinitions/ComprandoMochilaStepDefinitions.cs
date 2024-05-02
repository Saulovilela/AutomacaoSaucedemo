using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SpecFlowSaucedemo.Drivers;
using SpecFlowSaucedemo.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowSaucedemo.StepDefinitions
{
    [Binding]
    public class ComprandoMochilaStepDefinitions
    {
        private readonly IWebDriver driver;

        public ComprandoMochilaStepDefinitions()
        {
            driver = WebDriverFactory.GetDriver();
        }

        [Given(@"que eu clique na imagem da mochila")]
        public void GivenQueEuCliqueNaMochila()
        {
            ComprandoMochilaPage comprandoMochilaPage = new ComprandoMochilaPage();
            comprandoMochilaPage.ClicarImagemMochila(driver);
        }

        [When(@"clicar em add ao carrinho")]
        public void WhenClicarEmAddAoCarrinho()
        {
            Thread.Sleep(1000);
            ComprandoMochilaPage comprandoMochilaPage = new ComprandoMochilaPage();
            comprandoMochilaPage.ClicarAddToCart(driver);
        }

        [When(@"clicar no carrinho")]
        public void WhenClicarNoCarrinho()
        {
            ComprandoMochilaPage comprandoMochilaPage = new ComprandoMochilaPage();
            comprandoMochilaPage.ClicaCarrinho(driver);
        }

        [When(@"clicar em checkout")]
        public void WhenClicarEmCheckout()
        {
            ComprandoMochilaPage comprandoMochilaPage = new ComprandoMochilaPage();
            comprandoMochilaPage.ClicaCheckout(driver);
        }

        [When(@"coloco os dados de nome sobrenome e cep")]
        public void WhenColocoOsDadosDeNomeSobrenomeECep()
        {
            ComprandoMochilaPage comprandoMochilaPage = new ComprandoMochilaPage();
            comprandoMochilaPage.PreencheDados("teste", "teste 2", "0123456", driver);
        }

        [When(@"clico em finalizar")]
        public void WhenClicoEmFinalizar()
        {
            ComprandoMochilaPage comprandoMochilaPage = new ComprandoMochilaPage();
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Perform();
            System.Threading.Thread.Sleep(2000);
            comprandoMochilaPage.ClicaFinish(driver);
        }

        [Then(@"terei feito com sucesso a compra")]
        public void ThenTereiFeitoComSucessoACompra()
        {
            ComprandoMochilaPage comprandoMochilaPage = new ComprandoMochilaPage();
            comprandoMochilaPage.ValidatePhrase(driver);
        }
    }
}
