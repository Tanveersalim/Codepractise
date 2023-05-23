using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;



namespace Codepractise
{
    public class BaseClass
    {
        //Intialize webdriver
        public static IWebDriver driver=new ChromeDriver();
       

        public static string Headless { get; set; }
        public static string Browser { get; set; }

        //Create method selenium intialization
        public static void SeleniumInitialization()
        {
            //Check the browser which have used
            if (Browser == "Chrome")
            {
                var chromeOptions = new ChromeOptions();
                chromeOptions.AddArguments("headless");
                chromeOptions.AddArguments("--incognito");
                chromeOptions.AddArgument("--start-maximized");
                driver = new ChromeDriver(chromeOptions);
            }

            else if (Browser == "FireFox")
            {
                //FirefoxOptions options = new FirefoxOptions();
                //// options.AddArguments("--headless");
                //driver = new FirefoxDriver(options);
            }


        }
        
        //Create method of driver close
        public static void CloseSelenium()
        {
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

    }
}

    

