using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public class NavigateablePage: PageObject
    {
        private string url;
        public NavigateablePage(IWebDriver driver, string url) : base(driver)
        {
            this.url = url;
        }

        public void Navigate()
        {
            this.driver.Url = url;
        }
    }
}
