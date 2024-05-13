using OpenQA.Selenium;
using SpecFlowSaucedemo.Drivers;
using SpecFlowSaucedemo.Elements;
using SpecFlowSaucedemo.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowSaucedemo.StepDefinitions
{
    [Binding]
    public class DeixandoDeInserirValorNoCampoDeCepStepDefinitions
    {
        private readonly IWebDriver driver; // estamos chando o selenium para esse stepdefinition

        public DeixandoDeInserirValorNoCampoDeCepStepDefinitions()
        {
            driver = WebDriverFactory.GetDriver(); // declarando o driver que foi chamado na linha 11
        }

        [Given(@"Dado que estou na tela inicial")]
        public void GivenDadoQueEstouNaTelaInicial()
        {
        }

        [When(@"Quando Clico em Add to cart")]
        public void WhenQuandoClicoEmAddToCart()
        {
            Thread.Sleep(2000);
            NãoInserindoValorCepPage naoinserindovalorcep = new NãoInserindoValorCepPage();
            naoinserindovalorcep.AddToCart(driver);
        }

        [When(@"E Clico no botao de carrinho no canto superior direito")]
        public void WhenEClicoNoBotaoDeCarrinhoNoCantoSuperiorDireito()
        {
            Thread.Sleep(2000);
            NãoInserindoValorCepPage naoinserindovalorcep = new NãoInserindoValorCepPage();
            naoinserindovalorcep.ClicaCarrinho(driver);
        }

        [Then(@"Entao Serei levado a tela para fazer Checkout")]
        public void ThenEntaoSereiLevadoATelaParaFazerCheckout()
        {
        }

        [Given(@"Dado que Estou na tela de checkout")]
        public void GivenDadoQueEstouNaTelaDeCheckout()
        {
        }

        [When(@"Quando clico no botao de checkout")]
        public void WhenQuandoClicoNoBotaoDeCheckout()
        {
            Thread.Sleep(2000);
            NãoInserindoValorCepPage naoinserindovalorcep = new NãoInserindoValorCepPage();
            naoinserindovalorcep.ClicaCheckout(driver);
        }

        [Then(@"Entao serei levado para a tela de inserir dados para finalizar a compra")]
        public void ThenEntaoSereiLevadoParaATelaDeInserirDadosParaFinalizarACompra()
        {
        }

        [Given(@"Estou na tela de Preencher os dados da compra")]
        public void GivenEstouNaTelaDePreencherOsDadosDaCompra()
        {   
        }

        [When(@"Insiro first name e last name e deixo de inserir o campo Zip/Postal code")]
        public void WhenInsiroFirstNameELastNameEDeixoDeInserirOCampoZipPostalCode()
        {
            Thread.Sleep(2000);
            NãoInserindoValorCepPage naoinserindovalorcep = new NãoInserindoValorCepPage();
            naoinserindovalorcep.PreencheCamposObrigatorios("Marcelo", "Miranda", "", driver);
        }

        [When(@"E clico no botao continue")]
        public void WhenEClicoNoBotaoContinue()
        {
            Thread.Sleep(2000);
            NãoInserindoValorCepPage naoinserindovalorcep = new NãoInserindoValorCepPage();
            naoinserindovalorcep.ClicaContinue(driver);
        }

        [Then(@"Deve aparecer uma mensagem de erro em vermelho Error: Postal Code is required")]
        public void ThenDeveAparecerUmaMensagemDeErroEmVermelhoErrorPostalCodeIsRequired()
        {
            NãoInserindoValorCepPage naoinserindovalorcep = new NãoInserindoValorCepPage();
            naoinserindovalorcep.MensagemDeErro(driver);
            // teste
        }
    }
}
