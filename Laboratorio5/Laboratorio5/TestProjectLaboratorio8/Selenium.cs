using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProjectLaboratorio8
{
    public class Selenium
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();

        }
        [Test]
        public void PruebaIngresoCrearPaises()
        {
            string url = "https://localhost:44304/Paises/CrearPais";
            driver.Manage().Window.Maximize();
            driver.Url = url;
            Assert.IsTrue(driver.Url.Contains("CrearPais"));
            IWebElement dropdownContinente = driver.FindElement(By.Id("Continente"));
            IWebElement inputNombre = driver.FindElement(By.Id("Nombre"));
            IWebElement BotonCrear = driver.FindElement(By.Id("crearPais"));
            IWebElement inputIdioma = driver.FindElement(By.Id("Idioma"));
            Assert.IsNotNull(dropdownContinente);
            Assert.IsNotNull(inputNombre);
            Assert.IsNotNull(BotonCrear);
            Assert.IsNotNull(inputIdioma);
            inputNombre.SendKeys("Suecia");
            Assert.AreEqual("Suecia", inputNombre.GetAttribute("value"));
            dropdownContinente.SendKeys("Europa");
            Assert.IsNotNull(dropdownContinente);
            inputIdioma.SendKeys("Sueco");
            Assert.AreEqual("Sueco", inputIdioma.GetAttribute("value"));
            BotonCrear.Click();
        }
    }
}