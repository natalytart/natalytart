using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public class GithubHomePage : PageObject
    {
        public GithubHomePage(IWebDriver driver)
            : base(driver)
        {
                
        }
     
        public bool VerifyHomePage()
        {
            return this.actionbot.VerifyLabel(By.XPath("//h2[@class='shelf-title']"), "Learn Git and GitHub without any code!");

        }

        public void RepositorySearch()
        {
            this.actionbot.SetText(By.XPath("//input[@id='your-repos-filter']"), "test1");
            this.actionbot.ClickButton(By.XPath("//span[@title='natalytart/test2']"));
        }
    }
}
