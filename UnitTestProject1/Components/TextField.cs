using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public class TextField : Component
    {
        public TextField(IWebDriver driver, By locator)
            : base(driver, locator)
        {

        }

        public void SetText(string text)
        {
            this.actionbot.SetText(locator, text);
        }

        public void ClickOnText()
        {
            this.actionbot.ClickButton(this.locator);
        }
    }
}
