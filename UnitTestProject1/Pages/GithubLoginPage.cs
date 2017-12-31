using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public class GithubLoginPage: NavigateablePage
    { 
     
        public GithubLoginPage(IWebDriver driver, string url) : base(driver, url)
        {
        }

        public void Login(string userName, string password)
        {
            //הזנת שם משתמש וסיסמא
            this.actionbot.SetText(By.XPath("//input[@id='login_field']"), userName);
            this.actionbot.SetText(By.XPath("//input[@id='password']"), password);

            //לחיצה על לוגין
            this.actionbot.ClickButton(By.XPath("//input[@name='commit']"));
        }


    }
}
