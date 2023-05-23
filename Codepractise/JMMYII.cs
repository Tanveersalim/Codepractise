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
    class JMMYII : BaseClass
    {
        public void Jmmy(string url)
        {
            //Pass URL
            driver.Manage().Window.Maximize();
            driver.Url = url;
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;

            //apply scrolling
            js.ExecuteScript("window.scrollBy(0,300);");

            driver.FindElement(By.XPath("//div[@class='style_download__2J4k7 row']/*[name()='div'][1]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@class='style_download__2J4k7 row']/*[name()='div'][2]")).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,360);");
            driver.FindElement(By.XPath("//div[@class='p-2 rounded   col']//a[@href='/mobile-and-tablets']")).Click();
            Thread.Sleep(3000);
            driver.Navigate().Back();
            js.ExecuteScript("window.scrollBy(0,-360);");
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//div[@class='p-2 rounded   col']//a[@href='/home-lifestyle']")).Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//img[@src='https://plentyspkimages.s3.ap-south-1.amazonaws.com/bundledealsJMMYIIPlentysbannerGIF.gif']")).Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//img[@src='https://plentyspkimages.s3.ap-south-1.amazonaws.com/clearancesaleJMMYIIPlentysbannergif.gif']")).Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            js.ExecuteScript("window.scrollBy(0,390);");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//img[@src='https://plentyspkimages.s3.ap-south-1.amazonaws.com/plentysbluehourJMMYIIPlentysbanner.gif']")).Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//img[@src='https://plentyspkimages.s3.ap-south-1.amazonaws.com/ReversethewinterdrynessJMMYIIPlentysbanner.png']")).Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            driver.FindElement(By.XPath("//img[@src='https://plentyspkimages.s3.ap-south-1.amazonaws.com/MaintainthewinterglowJMMYIIPlentysbanner.png']")).Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            driver.FindElement(By.XPath("//img[@src='https://plentyspkimages.s3.ap-south-1.amazonaws.com/SayGoodbyetochappedlipsJMMYIIPlentysbanner.png']")).Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            driver.FindElement(By.XPath("//img[@src='https://plentyspkimages.s3.ap-south-1.amazonaws.com/instantrecovery.png']")).Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();

        }
    }
}
