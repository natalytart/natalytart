using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1
{
    [TestClass]
    public class GooglePage_UnitTest
    {
        [TestMethod]
        public void SearchInGoogle()
        {
            //לכל אלמנט ליצור IWebElement חדש
            //בגלל Ajax

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.co.il";

            IWebElement webElement1 = driver.FindElement(By.XPath("//input[@name='q']"));
            webElement1.SendKeys("tests");
            IWebElement webLogo = driver.FindElement(By.XPath("//img[@id='hplogo']"));
            webLogo.Click();           
            IWebElement webButtonSearch = driver.FindElement(By.XPath("//input[@name='btnK']"));
            webButtonSearch.Click();
        }
    }
}
