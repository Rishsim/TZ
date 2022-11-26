using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Job_Detials
{
    public class Class1
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            driver.Url = "https://testzenlabs.ie/job-details-form/";

            Thread.Sleep(2000);

            //IWebElement element1 = driver.FindElement(By.CssSelector("input[placeholder='Previous Company Name'"));

            //element1.SendKeys("Suresh");

            //Thread.Sleep(2000);

            //IWebElement element2 = driver.FindElement(By.CssSelector("input[placeholder='Current Company Name'"));

           //element2.SendKeys("Ramya");
            
            //Thread.Sleep(2000);

            //WebElement element3 = driver.FindElement(By.Name("bday"));

            //element3.SendKeys("05/02/1987");

            //Thread.Sleep(3000);

            //IList<IWebElement> element4= driver.FindElements(By.Name("bday"));

            //element4[1].SendKeys("15/07/2016");

            //Thread.Sleep(3000);

            //IList<IWebElement> element5 = driver.FindElements(By.Name("bday"));

            //element5[2].SendKeys("16/03/2021");

            //Thread.Sleep(3000);

            //IList<IWebElement> element6 = driver.FindElements(By.Name("bday"));

            //element6[3].SendKeys("18/03/20223");

            //Thread.Sleep(3000);

            //IWebElement element7 = driver.FindElement(By.Id("exp-2"));

            //element7.Click();

            //Thread.Sleep(3000);

            IWebElement element8 = driver.FindElement(By.Id("profession-1"));

            element8.Click();

            Thread.Sleep(3000);

            IWebElement element9 = driver.FindElement(By.Name("About-you"));

           element9.SendKeys("HardWorking");

            Thread.Sleep(2000);


            driver.Quit();




        }





    }
}
