using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using turnupportal.Pages;
using turnupportal.Utilities;

namespace turnupportal.Tests
{
    [TestFixture]
    [Parallelizable]
    class Employees_Tests : CommonDriver
    {
        [Test, Order(1)]
        public void CreateEmployeeTest()
        {
            //Home page object initialisation and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployee(driver);
            // Employee page object initialization and definition
            EmployeePages employeePageObj = new EmployeePages();
            employeePageObj.CreateEmployee(driver);

        }
        [Test, Order(2)]

        public void EditEmployeeTest()
        {
            //Home page object initialisation and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployee(driver);
            //Edit Tm
            EmployeePages employeePageObj = new EmployeePages();
            employeePageObj.EditEmployee(driver);
        }
        [Test, Order(3)]
        public void DeleteEmployeeTest()
        {
            //Home page object initialisation and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployee(driver);
            //delete Tm
            EmployeePages employeePageObj = new EmployeePages();
            employeePageObj.DeleteEmployee(driver);
        }


    }
}
