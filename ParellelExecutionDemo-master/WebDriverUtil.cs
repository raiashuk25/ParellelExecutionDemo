using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;

namespace ParellelExecutionDemo
{
    public enum BrowserType
    {
        Chrome,
        Firefox
    }
    public class WebDriverUtil
    {
        /// <summary>
        /// This method gets the webdriver  based on the browser type enum
        /// </summary>
        /// <param name="browserType"></param>
        /// <returns driver></returns>
        public IWebDriver GetDriver(BrowserType browserType)
        {
            //Based on the configuarion file values specified for the 
            // Execution type as local or Remote corresoinding drivers get called.
            if ( TestContext.Parameters["type"]=="local")
            {
                return GetLocalDriver(browserType);
            }
            else if (TestContext.Parameters["type"] == "remote")
            {
                string hubUrl = TestContext.Parameters["huburl"];
                return GetRemoteDriver(hubUrl, browserType);
            }
            else
            {
                return GetLocalDriver(browserType);
            }
        }
        /// <summary>
        /// This method gets the remote webdriver based on the desired configuration 
        /// </summary>
        /// <returns></returns>
        public  IWebDriver GetRemoteDriver(string hubUrl, BrowserType browserType)
        {
            IWebDriver driver = null;
            switch (browserType)
            {
                case BrowserType.Chrome:
                    ChromeOptions chromeOptions = new ChromeOptions();
                    driver = new RemoteWebDriver(new Uri(hubUrl), chromeOptions.ToCapabilities(), TimeSpan.FromSeconds(120));
                    break;
                case BrowserType.Firefox:
                    FirefoxOptions firefoxOptions = new FirefoxOptions();
                    driver = new RemoteWebDriver(new Uri(hubUrl), firefoxOptions.ToCapabilities(), TimeSpan.FromSeconds(120));
                    break;
                default:
                    throw new NotImplementedException();
            }
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            return driver;
        }

        /// <summary>
        /// This method gets the locak webdriver based on the browser type enum
        /// </summary>
        /// <param name="browserType"></param>
        /// <returns></returns>
        private  IWebDriver GetLocalDriver(BrowserType browserType)
        {
            IWebDriver driver = null;
            switch (browserType)
            {
                case BrowserType.Chrome:
                    ChromeOptions options = new ChromeOptions();
                    driver = new ChromeDriver();
                    driver.Manage().Window.Maximize();
                    driver.Manage().Cookies.DeleteAllCookies();
                    break;
                case BrowserType.Firefox:
                    driver = new FirefoxDriver();
                    driver.Manage().Window.Maximize();
                    driver.Manage().Cookies.DeleteAllCookies();
                    break;
                default:
                    throw new InvalidBrowserTypeException("Browser type selected is not valid" + browserType);
            }
            return driver;
        }

        /// <summary>
        /// This method returns the browser type enum
        /// </summary>
        /// <param name="browser"></param>
        /// <returns BrowserType></returns>
        public  BrowserType GetBrowserType(String browser)
        {
            BrowserType browserType;

            switch (browser)
            {
                case "Chrome":
                    browserType = BrowserType.Chrome;
                    break;
                case "Firefox":
                    browserType = BrowserType.Firefox;
                    break;
                default:
                    throw new InvalidBrowserTypeException("Invalid browser selection " + browser);
            }
            return browserType;
        }

    }
}
