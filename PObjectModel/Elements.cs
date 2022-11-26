using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PObjectModel
{
    public class Elements
    {
        public static void FunctionA(IWebDriver driver)
        {
            IWebElement elementA = driver.FindElement(By.CssSelector("input[placeholder='Your Name']"));

            elementA.SendKeys("Ramya");

            Thread.Sleep(3000);

            IWebElement elementB = driver.FindElement(By.CssSelector("input[placeholder='Your Middle Name']"));

            elementB.SendKeys("No");

            Thread.Sleep(3000);

            IWebElement elementC = driver.FindElement(By.CssSelector("input[placeholder='Your Last Name']"));

            elementC.SendKeys("Madhikanti");

            Thread.Sleep(3000);

            IWebElement elementD = driver.FindElement(By.CssSelector("input[placeholder='Phone Number']"));

            elementD.SendKeys("0857359147");

            Thread.Sleep(3000);

            IWebElement elementE = driver.FindElement(By.CssSelector("input[placeholder='Your Address']"));

            elementE.SendKeys("7 mount eustace park");

            Thread.Sleep(3000);

            IWebElement elementF = driver.FindElement(By.CssSelector("input[placeholder='Your Address']"));

            elementF.SendKeys("7 mount eustace park");

            Thread.Sleep(3000);

            IWebElement elementG = driver.FindElement(By.CssSelector("input[placeholder='Your Address Two']"));

            elementG.SendKeys("Tyrrelstown");

            Thread.Sleep(3000);

            IWebElement elementH = driver.FindElement(By.CssSelector("input[placeholder='Your Address three']"));

            elementH.SendKeys("Dublin");

            Thread.Sleep(3000);

            IWebElement elementI = driver.FindElement(By.CssSelector("input[placeholder='Your Pin Code']"));

            elementI.SendKeys("D15");

            Thread.Sleep(3000);

            IWebElement elementJ = driver.FindElement(By.Id("profession-1"));

            elementJ.Click();

            Thread.Sleep(3000);

            IWebElement elementK = driver.FindElement(By.Id("exp-1"));

            elementK.Click();

            Thread.Sleep(3000);

            IWebElement elementL = driver.FindElement(By.CssSelector("input[placeholder='Asia'"));

            elementK.SendKeys("Asia");


            Thread.Sleep(200);

            IWebElement elementM = driver.FindElement(By.LinkText("Switch To (Education Form)"));

            elementM.Click();

            Thread.Sleep(1000);

            driver.SwitchTo().Window(driver.WindowHandles.Last());

            IWebElement element1 = driver.FindElement(By.CssSelector("input[placeholder='Primary School Name']"));

            element1.SendKeys("Ich Dien Convent");

            Thread.Sleep(1000);

            IWebElement element2 = driver.FindElement(By.CssSelector("input[placeholder='Secondary School Name']"));

            element2.SendKeys("Ich Dien Convent");

            Thread.Sleep(3000);

            IWebElement element3 = driver.FindElement(By.CssSelector("input[placeholder='Intermediate College Name']"));

            element3.SendKeys("Geethanjali College");

            Thread.Sleep(3000);

            IWebElement element4 = driver.FindElement(By.CssSelector("input[placeholder='Engineering College Name']"));

            element4.SendKeys("Hits College");

            Thread.Sleep(3000);

            IWebElement element5 = driver.FindElement(By.CssSelector("input[placeholder='University Name']"));

            element5.SendKeys("Malla Reddy College of Pharmacy");

            Thread.Sleep(3000);

            IList<IWebElement> element6 = driver.FindElements(By.Id("continents-selectized"));

            element6[0].SendKeys("70%");

            Thread.Sleep(3000);

            IList<IWebElement> element7 = driver.FindElements(By.Id("continents-selectized"));

            element7[1].SendKeys("70%");

            Thread.Sleep(3000);

            IList<IWebElement> element8 = driver.FindElements(By.Id("continents-selectized"));

            element8[2].SendKeys("70%");

            Thread.Sleep(3000);

            IWebElement element9 = driver.FindElement(By.Id("profession-1"));

            element9.Click();

            Thread.Sleep(1000);

        }
    }
}
