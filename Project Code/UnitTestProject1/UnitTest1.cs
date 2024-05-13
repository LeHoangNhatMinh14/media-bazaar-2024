using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Threading;

namespace UnitTestProject1
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
            driver = new EdgeDriver("C:\\Users\\GT\\Downloads\\edgedriver_win64");
            driver.Manage().Window.Maximize();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
        [TestMethod]
        public void DashboardInteractionTest()
        {
           
            LoginTestMethod();
            LoginTestMethod2();
           
            var personalDataLink = driver.FindElement(By.LinkText("Personal Data"));
            personalDataLink.Click();

           
            wait.Until(ExpectedConditions.UrlContains("/PersonalData"));

           
            var mondayCheckbox = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='customCheckBox']/div[contains(text(), 'Monday')]")));

         
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", mondayCheckbox);
            Thread.Sleep(500); 

           
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", mondayCheckbox);

            var scheduleLink = wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Schedule")));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", scheduleLink);

           
            scheduleLink.Click();

           
            wait.Until(ExpectedConditions.UrlContains("/Schedule"));
            Assert.IsTrue(driver.Url.EndsWith("/Schedule"), "Failed to navigate to Schedule page.");
        }
        [TestMethod]
        public void LoginTestMethod()
        {
            Actions actions = new Actions(driver);

            driver.Navigate().GoToUrl("https://i493163.luna.fhict.nl");
            Thread.Sleep(1500);

            var emailField = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("form3Example3cg")));
            actions.MoveToElement(emailField).Perform();
            emailField.Clear();
            emailField.SendKeys("john.doe@example.com");  
            Thread.Sleep(1500);


            var passwordField = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("form3Example4cg")));
            actions.MoveToElement(passwordField).Perform();
            passwordField.Clear();
            actions.MoveToElement(passwordField).Perform();

            // Change the password input type from 'password' to 'text' to make the password visible
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].setAttribute('type', 'text');", passwordField);
            Thread.Sleep(500);  // Short pause to see the effect
            passwordField.SendKeys("wrongpassword"); 
            Thread.Sleep(1500);
           
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].setAttribute('type', 'text');", passwordField);
            Thread.Sleep(1500);
         
            var loginButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("button[type='submit']")));
            loginButton.Click();


        }
        public void LoginTestMethod2()
        {

            driver.Navigate().GoToUrl("https://i493163.luna.fhict.nl");
            Thread.Sleep(1500);

            var emailField = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("form3Example3cg")));
            emailField.Clear();
            emailField.SendKeys("john.doe@example.com");
            Thread.Sleep(1500);

            var passwordField = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("form3Example4cg")));
            passwordField.Clear();
            passwordField.SendKeys("password");
            Thread.Sleep(1500);

            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].setAttribute('type', 'text');", passwordField);
            Thread.Sleep(1500);

            var loginButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("button[type='submit']")));
            loginButton.Click();


        }
       


    }
}