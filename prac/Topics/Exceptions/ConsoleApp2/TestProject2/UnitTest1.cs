using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ConsoleApp2;

namespace TestProject2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl(" https://www.google.com/");

            driver.Manage().Window.Maximize();

            IWebElement webElement = driver.FindElement(By.Name("q"));

            webElement.SendKeys("Selenium");

            webElement.SendKeys(Keys.Return);
        }

        [Test]
        public void Test2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            SM.Click(driver, By.Id("loginLink"));
            SM.EnterText(driver, By.Name("Username"), "admin");
            SM.EnterText(driver, By.Name("Password"), "password");
            driver.FindElement(By.CssSelector(".btn")).Submit();
        }

        [Test]
        public void Test3() { 
              
        }
    }
}