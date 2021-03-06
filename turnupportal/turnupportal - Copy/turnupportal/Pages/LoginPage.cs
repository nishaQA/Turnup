using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using turnupportal.Utilities;

namespace turnupportal.Pages
{
    class LoginPage : CommonDriver
    {
        public void LoginSteps(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
             
            // launch turnup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            try
            {
                // identify username textbox and enter valid username
                IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
                usernameTextbox.SendKeys("hari");
                //Wait.WaitToBeVisible(driver, "Id", "Password", 2);
                // identify password textbox and enter valid password
                IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
                passwordTextbox.SendKeys("123123");
                // identify login button and click
                IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
                loginButton.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Turnup did not launch", ex.Message);
            }

        }
    }
}
