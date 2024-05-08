using OpenQA.Selenium;
using SpecFlowSaucedemo.Drivers;
using SpecFlowSaucedemo.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowSaucedemo.StepDefinitions
{
    [Binding]
    public class RemovendoUmProdutoStepDefinitions
    {
        private readonly IWebDriver driver; // estamos chando o selenium para esse stepdefinition

        public RemovendoUmProdutoStepDefinitions()
        {
            driver = WebDriverFactory.GetDriver();
        }

        [Given(@"Estou na tela inicial")]
        public void GivenEstouNaTelaInicial()
        {
        }

        [When(@"Clico em Add to cart")]public void WhenClicoEmAddToCart()
        {
            Thread.Sleep(4000);
            RemovendoCarrinhoPage removendocarrinhopage = new RemovendoCarrinhoPage();
            removendocarrinhopage.AddToCart(driver);
        }

        [When(@"Clico no botao de carrinho no canto superior direito")]
        public void WhenClicoNoBotaoDeCarrinhoNoCantoSuperiorDireito()
        {
            Thread.Sleep(4000);
            RemovendoCarrinhoPage removendocarrinhopage = new RemovendoCarrinhoPage();
            removendocarrinhopage.ClicaCarrinho(driver);
        }

        [Then(@"Serei levado a tela para fazer Checkout")]
        public void ThenSereiLevadoATelaParaFazerCheckout()
        {
        }

        [Given(@"Estou na tela de checkout")]
        public void GivenEstouNaTelaDeCheckout()
        {
        }

        [When(@"Clico no botao Remove")]
        public void WhenClicoNoBotaoRemove()
        {
            Thread.Sleep(4000);
            RemovendoCarrinhoPage removendocarrinhopage = new RemovendoCarrinhoPage();
            removendocarrinhopage.ClicaRemove(driver);
        }

        [Then(@"O produto adicionado deve ser removido do carrinho")]
        public void ThenOProdutoAdicionadoDeveSerRemovidoDoCarrinho()
        {
            // teste2
        }

        [Given(@"Apos o produto ser removido do carrinho")]
        public void GivenAposOProdutoSerRemovidoDoCarrinho()
        {
        }

        [When(@"Clico no botao continue shopping")]
        public void WhenClicoNoBotaoContinueShopping()
        {
            Thread.Sleep(4000);
            RemovendoCarrinhoPage removendocarrinhopage = new RemovendoCarrinhoPage();
            removendocarrinhopage.ClicaContinueShopping(driver);
        }

        [Then(@"Devo voltar a tela inicial com o botao add to cart disponivel para ser clicado novamente")]
        public void ThenDevoVoltarATelaInicialComOBotaoDisponivelParaSerClicadoNovamente()
        {
            Thread.Sleep(3000);
        }

    }
}
