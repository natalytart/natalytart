using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public abstract class Component
    {
        protected IWebDriver driver;
        protected Actionbot actionbot;
        protected By locator;
        public Component(IWebDriver driver, By locator)
        {
            this.driver = driver;
            this.actionbot = new Actionbot(this.driver);
            this.locator = locator;
        }
    }
}
