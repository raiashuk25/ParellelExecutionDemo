using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
[assembly: Parallelizable(ParallelScope.Children)]

namespace ParellelExecutionDemo
{

    [TestFixture]
    public class ChromeParellel
    {

        [Test]
        public void ChromeTest1()
        {
            WebDriverUtil webDriverUtil = new WebDriverUtil();
            IWebDriver Driver = webDriverUtil.GetDriver(BrowserType.Chrome);
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            Driver.FindElement(By.Id("search_query_top")).SendKeys(Guid.NewGuid().ToString());
            Driver.FindElement(By.XPath("//button[@name='submit_search']")).Click();
            string messageAfterClickingSearch = Driver.FindElement(By.XPath("//div[@id='center_column']//p[@class='alert alert-warning']")).Text;
            Assert.That(messageAfterClickingSearch, Does.Contain("No results were found for your search"));
            Driver.Quit();
            Driver.Dispose();
        }
        [Test]
        public void ChromeTest2()
        {
            WebDriverUtil webDriverUtil = new WebDriverUtil();
            IWebDriver Driver = webDriverUtil.GetDriver(BrowserType.Chrome);
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            Driver.FindElement(By.Id("search_query_top")).SendKeys(Guid.NewGuid().ToString());
            Driver.FindElement(By.XPath("//button[@name='submit_search']")).Click();
            string messageAfterClickingSearch = Driver.FindElement(By.XPath("//div[@id='center_column']//p[@class='alert alert-warning']")).Text;
            Assert.That(messageAfterClickingSearch, Does.Contain("No results were found for your search"));
            Driver.Quit();
            Driver.Dispose();
        }
        [Test]
        public void ChromeTest3()
        {
            WebDriverUtil webDriverUtil = new WebDriverUtil();
            IWebDriver Driver = webDriverUtil.GetDriver(BrowserType.Chrome);
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            Driver.FindElement(By.Id("search_query_top")).SendKeys(Guid.NewGuid().ToString());
            Driver.FindElement(By.XPath("//button[@name='submit_search']")).Click();
            string messageAfterClickingSearch = Driver.FindElement(By.XPath("//div[@id='center_column']//p[@class='alert alert-warning']")).Text;
            Assert.That(messageAfterClickingSearch, Does.Contain("No results were found for your search"));
            Driver.Quit();
            Driver.Dispose();
        }
        [Test]
        public void ChromeTest4()
        {
            WebDriverUtil webDriverUtil = new WebDriverUtil();
            IWebDriver Driver = webDriverUtil.GetDriver(BrowserType.Chrome);
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            Driver.FindElement(By.Id("search_query_top")).SendKeys(Guid.NewGuid().ToString());
            Driver.FindElement(By.XPath("//button[@name='submit_search']")).Click();
            string messageAfterClickingSearch = Driver.FindElement(By.XPath("//div[@id='center_column']//p[@class='alert alert-warning']")).Text;
            Assert.That(messageAfterClickingSearch, Does.Contain("No results were found for your search"));
            Driver.Quit();
            Driver.Dispose();
        }
        [Test]
        public void ChromeTest5()
        {
            WebDriverUtil webDriverUtil = new WebDriverUtil();
            IWebDriver Driver = webDriverUtil.GetDriver(BrowserType.Chrome);
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
