using Microsoft.Edge.SeleniumTools;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace CalculadoraAcceptanceTests.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        IWebDriver _driver;

        string urlDestino = "https://localhost:5001";

        private readonly ScenarioContext _scenarioContext;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"entro a la pagina de la calculadora")]
        public void GivenEntroALaPaginaDeLaCalculadora()
        {
            //INICILIZAR EL NAVEGADOR + DRIVER
            //EDGE CHROMIUM
            EdgeOptions edgeOptions = new EdgeOptions();
            edgeOptions.UseChromium = true;
            edgeOptions.AcceptInsecureCertificates = true;
            _driver = new EdgeDriver(edgeOptions);
            _driver.Manage().Window.Maximize();
            _driver.Url = urlDestino;
            System.Threading.Thread.Sleep(1000);
        }

        [Then(@"la operacion es suma")]
        public void ThenLaOperacionEsSuma()
        {
            var OperationType = _driver.FindElement(By.Name("OperationType"));
            var selectElement = new SelectElement(OperationType);
            selectElement.SelectByText("Suma");

        }

        [Then(@"el primer numero es (.*)")]
        public void ThenElPrimerNumeroEs(int p0)
        {
            _driver.FindElement(By.Id("NumberA")).SendKeys(p0.ToString());
            
        }

        [Then(@"el segundo numero (.*)")]
        public void ThenElSegundoNumero(int p0)
        {
            _driver.FindElement(By.Id("NumberB")).SendKeys(p0.ToString());
        }

        [Then(@"el resultado debe ser (.*)")]
        public void ThenElResultadoDebeSer(int p0)
        {
            _driver.FindElement(By.XPath("/html/body/div/main/form/div/div[5]/input")).Click();
            System.Threading.Thread.Sleep(1000);
            var resultado = _driver.FindElement(By.Id("Result")).GetAttribute("Value");

            Assert.AreEqual(p0.ToString(), resultado);

        }

        [Then(@"la operacion es multiplicacion")]
        public void ThenLaOperacionEsMultiplicacion()
        {
            var OperationType = _driver.FindElement(By.Name("OperationType"));
            var selectElement = new SelectElement(OperationType);
            selectElement.SelectByText("Multiplicacion");
        }

        [Then(@"el resultado es (.*)")]
        public void ThenElResultadoEs(int p0)
        {
            _driver.FindElement(By.XPath("/html/body/div/main/form/div/div[5]/input")).Click();
            System.Threading.Thread.Sleep(1000);
            var resultado = _driver.FindElement(By.Id("Result")).GetAttribute("Value");

            Assert.AreEqual(p0.ToString(), resultado);
        }

        [Then(@"la operacion es division")]
        public void ThenLaOperacionEsDivision()
        {
            var OperationType = _driver.FindElement(By.Name("OperationType"));
            var selectElement = new SelectElement(OperationType);
            selectElement.SelectByText("Division");
        }

        [Then(@"el resultado debe dar (.*)")]
        public void ThenElResultadoDebeDar(Decimal p0)
        {
            _driver.FindElement(By.XPath("/html/body/div/main/form/div/div[5]/input")).Click();
            System.Threading.Thread.Sleep(1000);
            var resultado = _driver.FindElement(By.Id("Result")).GetAttribute("Value");

            Assert.AreEqual(p0.ToString(), resultado.Replace(",", "."));
        }

        [Then(@"la operacion es resta")]
        public void ThenLaOperacionEsResta()
        {
            var OperationType = _driver.FindElement(By.Name("OperationType"));
            var selectElement = new SelectElement(OperationType);
            selectElement.SelectByText("Resta");
        }

        [Then(@"la operacion resulta (.*)")]
        public void ThenLaOperacionResulta(int p0)
        {
            _driver.FindElement(By.XPath("/html/body/div/main/form/div/div[5]/input")).Click();
            System.Threading.Thread.Sleep(1000);
            var resultado = _driver.FindElement(By.Id("Result")).GetAttribute("Value");
            Assert.AreEqual(p0.ToString(), resultado);
            _driver.Quit();
        }




    }
}
