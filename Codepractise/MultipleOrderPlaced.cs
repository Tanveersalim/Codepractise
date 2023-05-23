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
    class MultipleOrderPlaced : BaseClass
    {

        //Create MultiProduct Purchase method
        public void MultiProductpurchase(string url, string email, string pass, string category, string keywords, string productselect1,string productselect2,string productselect3, string firstname, string lastname, string housenum, string province, string city, string area, string zipcode, string phone)
        {

            //Pass URL
            driver.Manage().Window.Maximize();
            driver.Url = url;

            //Intialize javscriptexecutor
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;

            //input email and pass to login
            driver.FindElement(By.Id("loginEmail")).SendKeys(email);
            driver.FindElement(By.Id("loginPassword")).SendKeys(pass);
            driver.FindElement(By.XPath("//button[@class='_12lO5JGtDbFoA6jD7gaTqS btn btn-primary btn-block']")).Click();
            Thread.Sleep(3000);

            //Select Category of product
            var selection = driver.FindElement(By.Name("categoryId"));
            var selectdropdown = new SelectElement(selection);
            selectdropdown.SelectByText(category);

            //input of keywords in search bar
            driver.FindElement(By.XPath("//input[@class=' form-control T2knHkyKh7va8LumF90q6']")).SendKeys(keywords);
            driver.FindElement(By.XPath("//button[@class='_1QUWCim4JBX-9Rk5x7QMdn btn btn-primary']")).Click();


            //apply scrolling
            js.ExecuteScript("window.scrollBy(0,200);");
            Thread.Sleep(3000);

            //select product1
            driver.FindElement(By.XPath(productselect1)).Click();
            Thread.Sleep(4000);
            js.ExecuteScript("window.scrollBy(0,1500);");
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//button[@class='FFIsN4g-lYQn-2N5-C4nz btn btn-primary btn-block']")).Click();
            Thread.Sleep(3000);

            //Back Page and select another product
            driver.Navigate().Back();

            //select product2
            driver.FindElement(By.XPath(productselect2)).Click();
            Thread.Sleep(4000);
            js.ExecuteScript("window.scrollBy(0,1500);");
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//button[@class='FFIsN4g-lYQn-2N5-C4nz btn btn-primary btn-block']")).Click();
            Thread.Sleep(3000);

            //Back Page and select another product
            driver.Navigate().Back();

            //select product3
            driver.FindElement(By.XPath(productselect3)).Click();
            Thread.Sleep(4000);
            js.ExecuteScript("window.scrollBy(0,1500);");
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//button[@class='FFIsN4g-lYQn-2N5-C4nz btn btn-primary btn-block']")).Click();
            Thread.Sleep(3000);

            //Click Cart Button
            driver.FindElement(By.XPath("//span[@class='d-none d-xl-inline  _2qR-xBMdMuHW0d9LANYvcZ']")).Click();
            js.ExecuteScript("window.scrollBy(0,800);");
            Thread.Sleep(4000);

            //inputs of attributes
            driver.FindElement(By.XPath("//button[@class='_3JNubRXifRx3oVjFqOhhNl mr-2 rounded-0 btn btn-primary']")).Click();
            driver.FindElement(By.XPath("//button[@class='rounded-0 btn btn-outline-primary']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Name("firstName")).SendKeys(firstname);
            driver.FindElement(By.Name("lastName")).SendKeys(lastname);
            driver.FindElement(By.Name("houseNumber")).SendKeys(housenum);
            driver.FindElement(By.Name("address2")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath(province)).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath(city)).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath(area)).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.Name("zipCode")).SendKeys(zipcode);
            driver.FindElement(By.XPath("//input[@type='tel']")).SendKeys(phone);

            //submit form
            driver.FindElement(By.XPath("//div[@class='react-switch-bg']")).Click();
            driver.FindElement(By.XPath("//button[@class='mt-4 rounded-0 _2N7KCjlncfWXmViYHT2FEV btn btn-primary']")).Click();
            Thread.Sleep(4000);

            //select address
            driver.FindElement(By.XPath("//button[@class='_3JNubRXifRx3oVjFqOhhNl mr-2 rounded-0 btn btn-primary']")).Click();
            Thread.Sleep(3000);
            js.ExecuteScript("window.scrollBy(0,-1000);");
            Thread.Sleep(3000);

            //placed order
            driver.FindElement(By.XPath("//button[@class='_2eUzV9mH_kb0yqlBJPoEum btn btn-primary btn-block']")).Click();
            Thread.Sleep(4000);

            //Go to Order Page
            driver.FindElement(By.XPath("//div[@class='_3hr9rij5aFmslaAuXbcyU2']")).Click();
            driver.FindElement(By.XPath("//a[@href='/user/order']")).Click();
            Thread.Sleep(3000);
            js.ExecuteScript("window.scrollBy(0,300);");


            //Cancel Order1
            driver.FindElement(By.XPath("//button[@class='_169BWXjnxaIVp-m-NAmwjI btn btn-primary btn-block']")).Click();
            Thread.Sleep(3000);
            js.ExecuteScript("window.scrollBy(0,450);");
          

            //Cancel Order2
            driver.FindElement(By.XPath("//button[@class='_169BWXjnxaIVp-m-NAmwjI btn btn-primary btn-block']")).Click();
            Thread.Sleep(3000);

            //Cancel Order3
            driver.FindElement(By.XPath("//button[@class='_169BWXjnxaIVp-m-NAmwjI btn btn-primary btn-block']")).Click();
            Thread.Sleep(3000);

            //Logout Account
            driver.FindElement(By.XPath("//div[@class='_3hr9rij5aFmslaAuXbcyU2']")).Click();
            driver.FindElement(By.XPath("//a[text()='Logout']")).Click();
            // driver.Close();


        }
    }
}
