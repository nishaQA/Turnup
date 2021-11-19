using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using turnupportal.Utilities;

namespace turnupportal.Pages
{
    class EmployeePages : CommonDriver
    {
        public void CreateEmployee(IWebDriver driver)
        {
            //click on create new button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNewButton.Click();
            IWebElement nameTextBox = driver.FindElement(By.Id("Name"));
            nameTextBox.SendKeys("industry");

            IWebElement usernameTextBox = driver.FindElement(By.Id("UserName"));
            usernameTextBox.SendKeys("connect");
            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            passwordTextBox.SendKeys("Industry&connect0");
            
            IWebElement RetypePasswordTextBox = driver.FindElement(By.Id("RetypePassword"));
            RetypePasswordTextBox.SendKeys("Industry&connect0");


            IWebElement saveButton1 = driver.FindElement(By.Id("SaveButton"));
            saveButton1.Click();
            Thread.Sleep(2000);
            IWebElement backTolist = driver.FindElement(By.XPath("//*[@id='container']/div/a"));
            // check if record is created
            IWebElement lastPage1 = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            lastPage1.Click();
            Thread.Sleep(2000);
            IWebElement actualName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement actualUserName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            Assert.That(actualName.Text == "industry", "Actual name do not match match");
            Assert.That(actualUserName.Text == "connect", "Actual username do not match match");

        }
        public void EditEmployee(IWebDriver driver)
        {

        }
        public void DeleteEmployee(IWebDriver driver)
        {

        }
    }
}
