using OpenQA.Selenium;
using SpecFlowSaucedemo.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using SpecFlowSaucedemo.Pages;

namespace SpecFlowSaucedemo.Hooks
{

        [Binding]
        public class SpecflowHooks
        {
            private IWebDriver driver;
            private object? mainHandle;

            public SpecflowHooks() 
            {
            driver = WebDriverFactory.GetDriver();

            }

            [BeforeScenario("login")]
            public void BeforeScenario()
            {
                driver.Navigate().GoToUrl("https://www.saucedemo.com/");
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);

                LoginPage loginPage = new LoginPage();
                loginPage.PreencherLogin("standard_user", "secret_sauce", driver);
                loginPage.ClicarLogin(driver);
             }


            [AfterScenario]
            public void AfterScenario()
            {
                WebDriverFactory.CloseDriver();
            }

        }
    }
