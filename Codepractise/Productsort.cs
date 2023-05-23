using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Codepractise
{
    class Productsort : BaseClass
    {
        //Create Productsort method
        public void ProductSort(string url,string categoryselect,string stockavailable,string discountproduct,string lowtohighprice,string hightolowprice,string lowestrank,string highestrank)
        {
            //Intialize javscriptexecutor
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;


            //Pass URL
            driver.Manage().Window.Maximize();
            driver.Url = url;

            //Select ProductCategory
            driver.FindElement(By.XPath("//button[@class='_1nAxbZLRYNReXePkUOcBXK btn btn-primary']")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath(categoryselect)).Click();
            Thread.Sleep(4000);

            //Productsort
            var selection = driver.FindElement(By.XPath("//select[@class='custom-select custom-select-sm']"));
            var selectdropdown = new SelectElement(selection);
            selectdropdown.SelectByText(stockavailable);
            Thread.Sleep(3000);
            js.ExecuteScript("window.scrollBy(0,200);");
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,-200);");
            Thread.Sleep(3000);


            selectdropdown.SelectByText(discountproduct);
            Thread.Sleep(3000);
            js.ExecuteScript("window.scrollBy(0,200);");
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,-200);");
            Thread.Sleep(3000);

            selectdropdown.SelectByText(lowtohighprice);
            Thread.Sleep(3000);
            js.ExecuteScript("window.scrollBy(0,200);");
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,-200);");
            Thread.Sleep(3000);

            selectdropdown.SelectByText(hightolowprice);
            Thread.Sleep(3000);
            js.ExecuteScript("window.scrollBy(0,200);");
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,-200);");
            Thread.Sleep(3000);

            selectdropdown.SelectByText(lowestrank);
            Thread.Sleep(3000);
            js.ExecuteScript("window.scrollBy(0,200);");
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,-200);");
            Thread.Sleep(3000);

            selectdropdown.SelectByText(highestrank);
            Thread.Sleep(3000);
            js.ExecuteScript("window.scrollBy(0,200);");
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,-200);");
            Thread.Sleep(3000);

        }

        }
    }

