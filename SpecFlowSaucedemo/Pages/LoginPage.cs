using OpenQA.Selenium;
using SpecFlowSaucedemo.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowSaucedemo.Pages
{
    internal class LoginPage
    {
        public void PreencherLogin(string username, string password, IWebDriver driver)
        {
            driver.FindElement(By.Id(LoginElements.Username)).SendKeys(username);
            driver.FindElement(By.Id(LoginElements.Password)).SendKeys(password);
        }
        public void ClicarLogin(IWebDriver driver)
        {
            driver.FindElement(By.Id(LoginElements.BtnLogin)).Click();
        }
    }
}
