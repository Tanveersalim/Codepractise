using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Codepractise
{
    class Contactus : BaseClass
    {

        //Create Contact Method
        public void Contact(string url,string name,string email,string message,string expectedmessage)
        {
            //Pass URL
            driver.Manage().Window.Maximize();
            driver.Url = url;

            //Intialize javscriptexecutor
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            Thread.Sleep(3000);

            //apply scrolling
            js.ExecuteScript("window.scrollBy(0,100);");

            //inputs of attribute
            driver.FindElement(By.XPath("//input[@placeholder='Name']")).SendKeys(name);
            driver.FindElement(By.XPath("//input[@placeholder='Email']")).SendKeys(email);
            driver.FindElement(By.XPath("//textarea[@placeholder='Your Message']")).SendKeys(message);
            driver.FindElement(By.XPath("//button[@class='_1YAxRfka4vkV5rGZLCSLNh rounded btn btn-primary']")).Click();
            Thread.Sleep(2000);

            //Apply Assertion
            string actualmessage = driver.FindElement(By.XPath("//a[text()='product']")).Text;
            Assert.AreEqual(expectedmessage, actualmessage, "Assert Failed");
        }
    }
}
