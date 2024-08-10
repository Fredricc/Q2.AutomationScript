using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Q2.AutomationScript
{
        internal class SimpleTafrijatest
        {
            [Test]
            public void SimpleTest()
            {
                var driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://tafrija.azurewebsites.net/");
                Thread.Sleep(3000);

            driver.FindElement(By.Id("login")).Click();
                driver.FindElement(By.Id("Input_Email")).SendKeys("kfred45.fk@gmail.com");
                driver.FindElement(By.Id("Input_Password")).SendKeys("User@123");
                driver.FindElement(By.Id("login-submit")).Click();
                var currentUrl = driver.Url;
                Assert.That(currentUrl, Is.EqualTo("https://tafrija.azurewebsites.net/"), "This is not the home page");
                TestContext.Progress.WriteLine("Welcome to home page");

                driver.Quit();
            }
        }
    

}
