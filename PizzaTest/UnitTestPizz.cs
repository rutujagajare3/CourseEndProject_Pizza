using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace PizzaTest
{
    public class UnitTestPizz
    {
        [TestFixture]
        public class PizzaSelectionTests
        {
            private IWebDriver _driver;

            [SetUp]
            public void Setup()
            {
                _driver = new ChromeDriver();
                _driver.Navigate().GoToUrl("https://yourwebsite.com/pizza-selection");
            }

            [Test]
            public void TestPizzaSelection()
            {
                // Perform actions to select a pizza
                _driver.FindElement(By.Id("pizzaDropdown")).Click();
                _driver.FindElement(By.XPath("//option[contains(text(),'Pepperoni')]")).Click();
                _driver.FindElement(By.Id("addToCartButton")).Click();

                // Assert that the selected pizza is added to the cart
                Assert.That(_driver.PageSource.Contains("Pepperoni"));
            }

            [TearDown]
            public void Teardown()
            {
                _driver.Quit();
            }
        }
    }
}