using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PObjectModel
{
    public class Driver
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            driver.Url = "https://testzenlabs.ie/general-information-form/#";

            Thread.Sleep(2000);

            Elements.FunctionA(driver);

            driver.Quit();
        }
    }
}
