using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public class GithubRepository1Page : PageObject
    {
        public GithubRepository1Page(IWebDriver driver)
            : base(driver)
        {
                
        }

        public bool VerifyGithubRepository1()
        {
            return this.actionbot.VerifyLabel(By.XPath("//span[text()='Issues']"), "Issues");

        }

        public void ClickOnIssues()
        {
            TextField textField = new TextField(this.driver, By.XPath("//span[text()='Issues']"));
            textField.ClickOnText();
        }
    }
}
