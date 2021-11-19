using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace turnupportal.Pages
{
    class TMPage
    {

        public void CreateTM(IWebDriver driver)
        {
            //click on create new button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNewButton.Click();

            //click on typecode dropdown selecttime
            IWebElement typeCodeTime = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeTime.Click();

            IWebElement typeCodeTimebutton = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            typeCodeTimebutton.Click();
            //enter code
            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            codeTextBox.SendKeys("OCTOBER");
            //enter description
            IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
            descriptionTextBox.SendKeys("OCTOBERlist");
            //enter price
            IWebElement priceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span"));
            priceTag.Click();

            IWebElement priceTextBox = driver.FindElement(By.XPath("//*[@id='Price']"));
            priceTextBox.SendKeys("2");

            //save
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(2000);
            // check if record is created
            IWebElement lastPage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastPage.Click();
            Thread.Sleep(2000);
            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            // IWebElement actualTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            IWebElement actualDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement actualPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            Assert.That(actualCode.Text == "OCTOBER", "Actual code do not match match");
            //Assert.That(actualTypeCode.Text == "T", "Actual Typecode do not match match");
            Assert.That(actualDescription.Text == "OCTOBERlist", "Actual description do not match match");
            Assert.That(actualPrice.Text == "$2.00", "Actual price do not match match");
            Thread.Sleep(3000);

        }

        public void EditTM(IWebDriver driver)

           
        {
            Thread.Sleep(2000);
            IWebElement findRecordCreated = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            if (findRecordCreated.Text == "OCTOBER")
            {

                //open last page
                IWebElement lastPage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
                lastPage.Click();
                //
                //IWebElement actualCode1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]"));

                //click edit
                IWebElement edit = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                Thread.Sleep(2000);
                edit.Click();
                //click on typecode dropdown selecttime
                // IWebElement typeCodeTime1 = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
                // typeCodeTime1.Click();
                Thread.Sleep(2000);

                // IWebElement typeCodeTimebutton1 = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
                // typeCodeTimebutton1.Click();
                //enter code
                IWebElement codeTextBox1 = driver.FindElement(By.Id("Code"));
                codeTextBox1.Clear();
                codeTextBox1.SendKeys("OCTvedu");
                //enter description
                IWebElement descriptionTextBox1 = driver.FindElement(By.Id("Description"));
                descriptionTextBox1.Clear();
                Thread.Sleep(2000);
                descriptionTextBox1.SendKeys("OCTOBERupdated");
                //enter price
                IWebElement priceTag1 = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span"));
                priceTag1.Click();
                Thread.Sleep(2000);
                IWebElement priceTextBox1 = driver.FindElement(By.XPath("//*[@id='Price']"));
                priceTextBox1.Clear();
                Thread.Sleep(2000);
                IWebElement priceTag2 = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span"));
                priceTag2.Click();
                Thread.Sleep(2000);
                priceTextBox1.SendKeys("89");

                //save
                IWebElement saveButton1 = driver.FindElement(By.Id("SaveButton"));
                saveButton1.Click();
                Thread.Sleep(2000);
                Thread.Sleep(2000);
                //open last page
                IWebElement lastPage2 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
                lastPage2.Click();
                Thread.Sleep(2000);

                // Console.WriteLine("Record updated sucessfully");
                IWebElement EditedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
                // IWebElement EditedTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
                IWebElement EditedDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
                IWebElement EditedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
                Assert.That(EditedCode.Text == "OCTvedu", "Actual code do not match match");
                // Assert.That(EditedTypeCode.Text == "T", "Actual Typecode do not match match");
                Assert.That(EditedDescription.Text == "OCTOBERupdated", "Actual description do not match match");
                Assert.That(EditedPrice.Text == "$89.00", "Actual price do not match match");
            }
            else
            {
                Assert.Fail("Record to be edited not found");
            }

        }

        public void DeleteTM(IWebDriver driver)
        {
            IWebElement findEditedRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            if (findEditedRecord.Text == "OCTvedu")
            {
                //open last page
                IWebElement lastPage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
                lastPage.Click();

                Thread.Sleep(2000);
                // IWebElement EditedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
                IWebElement DeleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
                DeleteButton.Click();
                Thread.Sleep(2000);
                driver.SwitchTo().Alert().Accept();
                Console.WriteLine("Deleted item sucessfully");

                IWebElement lastPage2 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
                lastPage2.Click();
                Thread.Sleep(2000);

                // Console.WriteLine("Record updated sucessfully");
                IWebElement EditedCode1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
                // IWebElement EditedTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
                IWebElement EditedDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
                IWebElement EditedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
                Assert.That(EditedCode1.Text != "OCTvedu", "Actual code do not match match");
                // Assert.That(EditedTypeCode.Text != "T", "Actual Typecode do not match match");
                Assert.That(EditedDescription.Text != "OCTOBERupdated", "Actual description do not match match");
                Assert.That(EditedPrice.Text != "$89.00", "Actual price do not match match");
            }
            else
            {
                Assert.Fail("Record not deleted");
            }

        }
    }
}

