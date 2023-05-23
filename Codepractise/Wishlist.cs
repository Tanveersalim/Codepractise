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
    class Wishlist : BaseClass
    {
        //Create MultiProduct Purchase method
        public void WishList(string url, string email, string pass, string category, string keywords, string productselect1, string productselect2, string productselect3, string productselect4, string productselect5)
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

            //Back Page and select another product
            driver.Navigate().Back();

            //select product4
            driver.FindElement(By.XPath(productselect4)).Click();
            Thread.Sleep(4000);
            js.ExecuteScript("window.scrollBy(0,1500);");
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//button[@class='FFIsN4g-lYQn-2N5-C4nz btn btn-primary btn-block']")).Click();
            Thread.Sleep(3000);

            //Back Page and select another product
            driver.Navigate().Back();

            //select product5
            driver.FindElement(By.XPath(productselect5)).Click();
            Thread.Sleep(4000);
            js.ExecuteScript("window.scrollBy(0,1500);");
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//button[@class='FFIsN4g-lYQn-2N5-C4nz btn btn-primary btn-block']")).Click();
            Thread.Sleep(3000);


            //Click Cart Button
            driver.FindElement(By.XPath("//span[@class='d-none d-xl-inline  _2qR-xBMdMuHW0d9LANYvcZ']")).Click();
            Thread.Sleep(4000);


            for(int i = 0; i < 5; i++)
            {
                //Save product
                driver.FindElement(By.XPath("//button[@class='rounded-0  btn btn-outline-primary ']")).Click();
                //js.ExecuteScript("window.scrollBy(0,800);");
                Thread.Sleep(1000);
            }
         
            //Go to Wishlist Page
            driver.FindElement(By.XPath("//div[@class='_3hr9rij5aFmslaAuXbcyU2']")).Click();
            driver.FindElement(By.XPath("//a[@href='/user/wish-list']")).Click();
            Thread.Sleep(3000);


            for(int i = 0; i < 5; i++)
            {
                //Go to Delete Product1 from wishlist
                driver.FindElement(By.XPath("//button[@class=' rounded-0 btn btn-outline-danger btn-block']")).Click();
                driver.FindElement(By.XPath("//div[@class='swal2-actions']/*[name()='button'][1]")).Click();
                Thread.Sleep(3000);
            }
         
            //Logout Account
            driver.FindElement(By.XPath("//div[@class='_3hr9rij5aFmslaAuXbcyU2']")).Click();
            driver.FindElement(By.XPath("//a[text()='Logout']")).Click();
            // driver.Close();


        }
    }
}
