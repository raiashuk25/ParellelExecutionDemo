using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using ParellelExecutionDemo;
using System;

namespace FirefoxParellel
{
    [TestFixture]
    //[Ignore("")]
    public class FirefoxParellel 
    {

        [Test]
        public  void FirefoxTest1()
        {
            WebDriverUtil webDriverUtil = new WebDriverUtil();
            IWebDriver Driver = webDriverUtil.GetDriver(BrowserType.Firefox);
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            Driver.FindElement(By.Id("search_query_top")).SendKeys(Guid.NewGuid().ToString());
            Driver.FindElement(By.XPath("//button[@name='submit_search']")).Click();
            string messageAfterClickingSearch = Driver.FindElement(By.XPath("//div[@id='center_column']//p[@class='alert alert-warning']")).Text;
            Assert.That(messageAfterClickingSearch, Does.Contain("No results were found for your search"));
            Driver.Quit();
            Driver.Dispose();
        }

        [Test]
        public void FirefoxTest2()
        {
            WebDriverUtil webDriverUtil = new WebDriverUtil();
            IWebDriver Driver = webDriverUtil.GetDriver(BrowserType.Firefox);
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            Driver.FindElement(By.Id("search_query_top")).SendKeys(Guid.NewGuid().ToString());
            Driver.FindElement(By.XPath("//button[@name='submit_search']")).Click();
            string messageAfterClickingSearch = Driver.FindElement(By.XPath("//div[@id='center_column']//p[@class='alert alert-warning']")).Text;
            Assert.That(messageAfterClickingSearch, Does.Contain("No results were found for your search"));
            Driver.Quit();
            Driver.Dispose();
        }
        [Test]
        public void FirefoxTest3()
        {
            WebDriverUtil webDriverUtil = new WebDriverUtil();
            IWebDriver Driver = webDriverUtil.GetDriver(BrowserType.Firefox);
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            Driver.FindElement(By.Id("search_query_top")).SendKeys(Guid.NewGuid().ToString());
            Driver.FindElement(By.XPath("//button[@name='submit_search']")).Click();
            string messageAfterClickingSearch = Driver.FindElement(By.XPath("//div[@id='center_column']//p[@class='alert alert-warning']")).Text;
            Assert.That(messageAfterClickingSearch, Does.Contain("No results were found for your search"));
            Driver.Quit();
            Driver.Dispose();
        }
        [Test]
        public void FirefoxTest4()
        {
            WebDriverUtil webDriverUtil = new WebDriverUtil();
            IWebDriver Driver = webDriverUtil.GetDriver(BrowserType.Firefox);
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            Driver.FindElement(By.Id("search_query_top")).SendKeys(Guid.NewGuid().ToString());
            Driver.FindElement(By.XPath("//button[@name='submit_search']")).Click();
            string messageAfterClickingSearch = Driver.FindElement(By.XPath("//div[@id='center_column']//p[@class='alert alert-warning']")).Text;
            Assert.That(messageAfterClickingSearch, Does.Contain("No results were found for your search"));
            Driver.Quit();
            Driver.Dispose();
        }
        [Test]
        public void FirefoxTest5()
        {
            WebDriverUtil webDriverUtil = new WebDriverUtil();
            IWebDriver Driver = webDriverUtil.GetDriver(BrowserType.Firefox);
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            Driver.FindElement(By.Id("search_query_top")).SendKeys(Guid.NewGuid().ToString());
            Driver.FindElement(By.XPath("//button[@name='submit_search']")).Click();
            string messageAfterClickingSearch = Driver.FindElement(By.XPath("//div[@id='center_column']//p[@class='alert alert-warning']")).Text;
            Assert.That(messageAfterClickingSearch, Does.Contain("No results were found for your search"));
            Driver.Quit();
            Driver.Dispose();
        }


    }
    
}