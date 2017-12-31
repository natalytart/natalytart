using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;

namespace UnitTestProject1
{
    [TestClass]
    public class GitHub_UnitTest
    {
        IWebDriver driver;

        [SetUp]
        public void BeforeRun()
        {
            driver = new ChromeDriver();
        }

        [TearDown]
        public void AfterRun()
        {
            driver.Close();
        }

        [Test]
        public void UseGitHub()
        {
            //לוגין
            string url = "https://github.com/login";

            GithubLoginPage githubLoginPage = new GithubLoginPage(driver, url);

            githubLoginPage.Navigate();

            githubLoginPage.Login("natalytart", "tartak1024");

            //פעולות בדף הבית
            GithubHomePage githubHomePage = new GithubHomePage(driver);
            if (githubHomePage.VerifyHomePage())
                githubHomePage.RepositorySearch();

            //פעולות ברפוזיטורי הראשון
            GithubRepository1Page githubRepository1Page = new GithubRepository1Page(driver);
            if (githubRepository1Page.VerifyGithubRepository1())
                githubRepository1Page.ClickOnIssues();
        }
      
    }
}
