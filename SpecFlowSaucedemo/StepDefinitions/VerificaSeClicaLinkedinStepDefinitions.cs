using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SpecFlowSaucedemo.Drivers;
using SpecFlowSaucedemo.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowSaucedemo.StepDefinitions
{
    [Binding]
    public class VerificaSeClicaLinkedinStepDefinitions
    {

        private readonly IWebDriver driver;

        public VerificaSeClicaLinkedinStepDefinitions()
        {
            driver = WebDriverFactory.GetDriver();
        }

        [Given(@"Estou na pagina inicial")]
        public void GivenEstouNaPaginaInicial()
        {
        }

        [When(@"Rolo a tela para baixo")]
        public void WhenRoloATelaParaBaixo()
        {
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Perform();
            Thread.Sleep(3000);
        }

        [When(@"Clico no botao do Linkedin")]
        public void WhenClicoNoBotaoDoLinkedin()
        {
            VerificaSeLevaParaPaginaLinkedinPage VerificaSeLevaParaPaginaLinkedin = new VerificaSeLevaParaPaginaLinkedinPage();
            VerificaSeLevaParaPaginaLinkedin.ClicaBtnLinkedin(driver);
            Thread.Sleep(2000);
        }

        [Then(@"Devo ser redirecionado para a URL do Linkedin da empresa")]
        public void ThenDevoSerRedirecionadoParaAURLDoLinkedinDaEmpresa()
        {
            driver.Navigate().GoToUrl("https://www.linkedin.com/company/sauce-labs/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }
    }
}
