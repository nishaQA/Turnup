using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using turnupportal.Pages;

namespace turnupportal.Utilities
{
    class CommonDriver
    {

        public IWebDriver driver;
        [OneTimeSetUp]
        public void LoginActions()
        {
            driver = new ChromeDriver();
            // Login Page Object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);

           

        }
        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Quit();

        }
    }
}
