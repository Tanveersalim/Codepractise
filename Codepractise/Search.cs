using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Codepractise
{
    class Search : BaseClass
    {
        //Create Searchproduct method
        public void Searchproduct(string url, string keywords)
        {
            //Pass URL
            driver.Manage().Window.Maximize();          
            driver.Url = url;

            //Intialize javscriptexecutor
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;

            //Intialize actions class
            Actions action = new Actions(driver);

            //input keywords in search bar
            driver.FindElement(By.XPath("//input[@class=' form-control T2knHkyKh7va8LumF90q6']")).SendKeys(keywords);
            driver.FindElement(By.XPath("//button[@class='_1QUWCim4JBX-9Rk5x7QMdn btn btn-primary']")).Click();
            Thread.Sleep(2000);

            //apply scrolling
            js.ExecuteScript("window.scrollBy(0,100);");

            //apply some action in search bar
            action.Click(driver.FindElement(By.XPath("//input[@class=' form-control T2knHkyKh7va8LumF90q6']")))
                .KeyDown(Keys.Control)
                .SendKeys(Keys.Backspace)
                .KeyUp(Keys.Control)
                .Build()
                .Perform();
            Thread.Sleep(1000);
            





        }
    }
}
