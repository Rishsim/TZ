using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Located_With_ID
{
    public class Class1
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            driver.Url = "https://www.facebook.com/";

            Thread.Sleep(2000);

            IWebElement element1 = driver.FindElement(By.Id("email"));

            element1.SendKeys("ramya0502@gmail.com");

            Thread.Sleep(2000);

            IWebElement element2 = driver.FindElement(By.Id("pass"));

           element2.SendKeys("suresh143");

            Thread.Sleep(2000);

            IWebElement elementx = driver.FindElement(By.Name("login"));

            elementx.Click();

            Thread.Sleep(2000);

            driver.Manage().Window.Maximize();

            driver.Url = "https://www.boots.ie/LoginRequestDispatcher";
            

            Thread.Sleep(2000);

            IWebElement element3 = driver.FindElement(By.Id("gigya-loginID-126189670420823710"));

            element3.SendKeys("ramya0502@gmail.com");

            Thread.Sleep(2000);

            IWebElement element4 = driver.FindElement(By.Id("gigya-password-21094567555302330"));

            element4.SendKeys("suresh143");

            Thread.Sleep(2000);

            IWebElement element5 = driver.FindElement(By.Id("__gig_template_element_16_1662241315331"));

            element5.Click();

            IWebElement element6= driver.FindElement(By.Id("__gig_template_element_7_1662241315330"));

            element6.Click();

            Thread.Sleep(1000);

            driver.Quit();



        }

    }
}
