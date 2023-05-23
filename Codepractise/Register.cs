using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Codepractise
{
    class Register : BaseClass
    {
        //Create Postive testcase method
     public void Positivecase(string url,string name,string email,string phone,string pass,string confirmpass)
        {
            //Pass URL
            driver.Manage().Window.Maximize();
            driver.Url = url;

            //input of attribute
            driver.FindElement(By.Id("registrationFullName")).SendKeys(name);
            driver.FindElement(By.Id("registrationEmail")).SendKeys(email);
            driver.FindElement(By.XPath("//input[@type='tel']")).SendKeys(phone);
            driver.FindElement(By.Id("registrationPassword")).SendKeys(pass);
            driver.FindElement(By.Id("registrationConfirmPassword")).SendKeys(confirmpass);
            Thread.Sleep(6000);

            //apply input
            driver.FindElement(By.XPath("//button[@class='_3WXSrRXBjDsdqtItobxS-B rounded-0 btn btn-primary']")).Click();
            Thread.Sleep(4000);
            driver.Close();
        }

        //Create Negative testcase method
        public void NegativeCase(string url, string name, string email, string phone, string pass, string confirmpass)
        {
            //Pass URL
            driver.Manage().Window.Maximize();
            driver.Url = url;

            //input of attribute
            driver.FindElement(By.Id("registrationFullName")).SendKeys(name);
            driver.FindElement(By.Id("registrationEmail")).SendKeys(email);
            driver.FindElement(By.XPath("//input[@type='tel']")).SendKeys(phone);
            driver.FindElement(By.Id("registrationPassword")).SendKeys(pass);
            driver.FindElement(By.Id("registrationConfirmPassword")).SendKeys(confirmpass);
            Thread.Sleep(6000);

            //apply input
            driver.FindElement(By.XPath("//button[@class='_3WXSrRXBjDsdqtItobxS-B rounded-0 btn btn-primary']")).Click();
            Thread.Sleep(4000);
            //driver.Close();

        }
        
    }
}
