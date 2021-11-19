using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using turnupportal.Pages;
using turnupportal.Utilities;

namespace turnupportal.Tests
{
    [TestFixture]
    [Parallelizable]
    class TMTests : CommonDriver
    {
      
            [Test, Order(1)]
            public void CreateTMTest()
            {
            // Home page object initialisation and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);
            Thread.Sleep(2000);
            // TM page object initialization and definition
            TMPage tmPageObj = new TMPage();
                tmPageObj.CreateTM(driver);

            }
            [Test, Order(2)]

            public void EditTMTest()
            {
            // Home page object initialisation and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            //Edit Tm
            TMPage tmPageObj = new TMPage();
                tmPageObj.EditTM(driver);
            }
            [Test, Order(3)]
            public void DeleteTMTest()
            {
            // Home page object initialisation and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            //delete Tm
            TMPage tmPageObj = new TMPage();
                tmPageObj.DeleteTM(driver);
            }


        

    }
}
