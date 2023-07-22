using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodbyeLife
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets play noughts & crosses");
            //Console.ReadLine();

            // Create a driver instance for chromedriver
            IWebDriver driver = new ChromeDriver();

            //Navigate to google page
            driver.Navigate().GoToUrl("http:www.google.com");

            //Maximize the window
            driver.Manage().Window.Maximize();

           
            //Find the Search text box using xpath
            IWebElement  beforeYouContinue = driver.FindElement(By.Id("W0wltc"));
            beforeYouContinue.Click();

            //Find the Search text box using xpath
            IWebElement element = driver.FindElement(By.XPath("//*[@title='Search']"));

            //Enter some text in search text box
            element.SendKeys("tic-tac-toe");

            IWebElement middleX = driver.FindElement(By.XPath("xpath=//tr[2]/td[2]"));

            middleX.Click();

            //Close the browser
            driver.Close();
        }
    }
}
