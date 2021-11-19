using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace turnupportal.Pages
{
    class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {
            //click on admintab
            IWebElement adminTab = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / a / span"));
            adminTab.Click();
            Thread.Sleep(2000);
            //  Wait.WaitToBeClickable(driver, "Xpath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a, 3 ");
            // Select Time and Matereial
            IWebElement tmTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmTab.Click();

        }

        public void GoToEmployee(IWebDriver driver)
        {
            //navigate to employees page
            IWebElement adminTab = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / a / span"));
            adminTab.Click();
            Thread.Sleep(2000);
            //  Wait.WaitToBeClickable(driver, "Xpath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a, 3 ");
            // Select Time and Matereial
            IWebElement EmployeeTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            EmployeeTab.Click();
          

        }
    }
}
