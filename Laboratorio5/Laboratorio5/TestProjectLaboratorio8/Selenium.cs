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
            string URL = "";
            driver.Manage().Window.Maximize();
            driver.Url = URL;
            Assert.IsNotNull(driver);
        }
    }

}
