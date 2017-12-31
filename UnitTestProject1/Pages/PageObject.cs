using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public abstract class PageObject
    {
        protected IWebDriver driver;
        protected Actionbot actionbot;
        public PageObject(IWebDriver driver)
        {
            this.driver = driver;
            this.actionbot = new Actionbot(this.driver);
        }
    }
}

