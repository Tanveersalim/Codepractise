using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace Codepractise
{
    class TrackingOrder : BaseClass
    {

        //Create Track Order Method
        public void TrackOrder(string url,string orderid,string email)
        {

            //Intialize actions class
            Actions action = new Actions(driver);

            //Pass URL
            driver.Manage().Window.Maximize();
            driver.Url = url;


            //Intialize javscriptexecutor
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            Thread.Sleep(3000);

            //Apply Scrolling 
            js.ExecuteScript("window.scrollBy(0,200);");

            //inputs of attribute
            driver.FindElement(By.XPath("//input[@placeholder='Order Number']")).SendKeys(orderid);
            driver.FindElement(By.XPath("//input[@placeholder='Your Email Address']")).SendKeys(email);
            driver.FindElement(By.XPath("//button[@class='rounded-0 btn btn-success btn-block']")).Click();
            Thread.Sleep(2000);

            //Apply Scrolling
            js.ExecuteScript("window.scrollBy(0,300);");
            Thread.Sleep(3000);
            
            
        }
    }
}
