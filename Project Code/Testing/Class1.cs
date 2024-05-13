using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Testing
{
    [TestClass]
    public class IntegrationTest
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [TestInitialize]
        public void SetUp()
        {
            // Initialize Edge WebDriver
            driver = new EdgeDriver("C:\\Path\\To\\Your\\EdgeDriver");
            driver.Manage().Window.Maximize();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        [TestMethod]
        public void LoginTestMethod()
        {
            // Navigate to the login page
            driver.Navigate().GoToUrl("https://i493163.luna.fhict.nl/Login");
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("Login_Username"))).SendKeys("admin");
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("Login_Password"))).SendKeys("password123");

            // Submit the login form
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("button[type='submit']"))).Click();

            // Check if login was successful by verifying the presence of an element that appears only upon login
            Assert.IsTrue(wait.Until(ExpectedConditions.ElementIsVisible(By.Id("dashboard"))).Displayed, "Login failed or dashboard not found.");
        }

        [TestMethod]
        public void NavigateAllMenuItemsTestMethod()
        {
            // First, perform login
            LoginTestMethod();

            // Define the URLs or parts of URLs that represent different sections of the site
            var menuItems = new List<string> { "Dashboard", "Employees", "Schedule", "Products" };

            foreach (var item in menuItems)
            {
                var link = wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText(item)));
                link.Click();
                Thread.Sleep(1000); // Using Thread.Sleep for demonstration; ideally use WebDriverWait to wait for specific page elements

                // Confirm that the correct page has loaded
                Assert.IsTrue(driver.Url.Contains(item), $"Navigation to {item} failed or incorrect.");
            }
        }

        private void TearDown()
        {
            // Close the browser and dispose of the driver instance
            driver.Quit();
        }
    }
}