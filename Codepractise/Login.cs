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
    public class Login : BaseClass
    {
       
        //Create Positive testcase method
        public void Positivecase(string url,string email,string pass,string message,string locator)
        {
            //Pass URL
            driver.Url = url;
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//span[@class='d-none d-xl-inline _3adI5bw6jZUVGlL17EPMRN']")).Click();

            //Input email and pass
            driver.FindElement(By.Id("loginEmail")).SendKeys(email);
            driver.FindElement(By.Id("loginPassword")).SendKeys(pass);
            driver.FindElement(By.XPath("//button[@class='_12lO5JGtDbFoA6jD7gaTqS btn btn-primary btn-block']")).Click();
            Thread.Sleep(4000);
 
            //open profile page
            driver.FindElement(By.XPath("//div[@class='_3hr9rij5aFmslaAuXbcyU2']")).Click();
            driver.FindElement(By.XPath("//a[@href='/user/profile']")).Click();
            Thread.Sleep(4000);

            //apply Assertion
            string actualmessage = driver.FindElement(By.XPath(locator)).Text;
            Assert.AreEqual(message, actualmessage, "Login Failed due to invalid data");
            CloseSelenium();           
        }

        //Create Negative testcase method
        public void NegativeCase(string url,string email, string pass, string message, string locator)
        {
            //Pass URL
            driver.Url = url;
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//span[@class='d-none d-xl-inline _3adI5bw6jZUVGlL17EPMRN']")).Click();

            //Input email and pass
            driver.FindElement(By.Id("loginEmail")).SendKeys(email);
            driver.FindElement(By.Id("loginPassword")).SendKeys(pass);
            driver.FindElement(By.XPath("//button[@class='_12lO5JGtDbFoA6jD7gaTqS btn btn-primary btn-block']")).Click();

            //apply Assertion
            string actualmessage = driver.FindElement(By.XPath(locator)).Text;
            Thread.Sleep(4000);
            Assert.AreEqual(message, actualmessage, "Login Failed due to invalid data");
            


        }

    }

}
