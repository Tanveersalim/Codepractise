using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Codepractise
{
    class Productreview : BaseClass
    {
        //Create Productreview Method
        public void Review(string url, string email, string pass, string keywords, string productselect,string rating, string reviewtitle, string comment,string editrating,string editreview,string editcomment)
        {
            //Pass URL
            driver.Manage().Window.Maximize();
            driver.Url = url;

            //Intialize javscriptexecutor
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;

            //Go to login page
            driver.FindElement(By.XPath("//span[@class='d-none d-xl-inline _3adI5bw6jZUVGlL17EPMRN']")).Click();

            //input email and pass
            driver.FindElement(By.Id("loginEmail")).SendKeys(email);
            driver.FindElement(By.Id("loginPassword")).SendKeys(pass);
            driver.FindElement(By.XPath("//button[@class='_12lO5JGtDbFoA6jD7gaTqS btn btn-primary btn-block']")).Click();
            Thread.Sleep(3000);

            //input keyword in search bar
            driver.FindElement(By.XPath("//input[@class=' form-control T2knHkyKh7va8LumF90q6']")).SendKeys(keywords);
            driver.FindElement(By.XPath("//button[@class='_1QUWCim4JBX-9Rk5x7QMdn btn btn-primary']")).Click();

            //Apply Scrolling
            js.ExecuteScript("window.scrollBy(0,50);");
            Thread.Sleep(3000);

            //Select Product
            driver.FindElement(By.XPath(productselect)).Click();
            Thread.Sleep(4000);
            js.ExecuteScript("window.scrollBy(0,1200);");

            //Open Review Alert Box
            driver.FindElement(By.XPath("//button[@class='float-right btn btn-primary']")).Click();
            Thread.Sleep(3000);

            //Intialize actions class
            Actions actions = new Actions(driver);

            //Find Rating Star Element
            IWebElement star = driver.FindElement(By.XPath(rating));
            actions.MoveToElement(star);
            actions.Click().Perform();

            //input attributes
            driver.FindElement(By.XPath("//input[@placeholder='Enter review title']")).SendKeys(reviewtitle);
            driver.FindElement(By.XPath("//textarea[@placeholder='Enter review']")).SendKeys(comment);

            /*Image Upload
            IWebElement fileupload = driver.FindElement(By.XPath("//button[@class='_2wWZKS_gA-8hKfd2DtsLLR']"));
            fileupload.SendKeys(@"C:/Users/840 G3/pics.png");
            fileupload.Click();
            Thread.Sleep(3000);*/

            //Submit Review
            driver.FindElement(By.XPath("//button[@class='rounded-0 btn btn-success']")).Click();
            Thread.Sleep(4000);

            //Edit Rating star
            driver.FindElement(By.XPath("//div[@class='text-right col']/*[name()='svg'][1]")).Click();
            Thread.Sleep(4000);
            IWebElement stars = driver.FindElement(By.XPath(editrating));
            actions.MoveToElement(stars);
            actions.Click().Perform();

            //Edit Review Title
            actions.Click(driver.FindElement(By.XPath("//input[@id='reviewTitle']")))
              .KeyDown(Keys.Control)
              .SendKeys(Keys.Backspace)
              .SendKeys(Keys.Backspace)
              .SendKeys(Keys.Backspace)
              .KeyUp(Keys.Control)
              .Build()
              .Perform();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@id='reviewTitle']")).SendKeys(editreview);

            //Edit Comment
            actions.Click(driver.FindElement(By.XPath("//div[@class='form-group']/*[name()='textarea']")))
              .KeyDown(Keys.Control)
              .SendKeys(Keys.Backspace)
              .SendKeys(Keys.Backspace)
              .SendKeys(Keys.Backspace)
              .SendKeys(Keys.Backspace)
              .KeyUp(Keys.Control)             
              .Build()
              .Perform();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@class='form-group']/*[name()='textarea']")).SendKeys(editcomment);

            //Submit Re-Edit Reviews
            driver.FindElement(By.XPath("//button[@class='_24S5gNOCmILR89sA2ra_7w rounded-0 btn btn-primary btn-block btn-sm']")).Click();
            Thread.Sleep(3000);
            js.ExecuteScript("window.scrollBy(0,-200);");

            //Delete Review
            driver.FindElement(By.XPath("//div[@class='text-right col']/*[name()='svg'][2]")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//div[@class='swal2-actions']/*[name()='button'][1]")).Click();

            //Logout Account
            driver.FindElement(By.XPath("//div[@class='_3hr9rij5aFmslaAuXbcyU2']")).Click();
            driver.FindElement(By.XPath("//a[text()='Logout']")).Click();
            // driver.Close();

        }
    }
}
