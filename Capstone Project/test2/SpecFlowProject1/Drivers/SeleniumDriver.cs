using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Drivers
{
    public class SeleniumDriver
    {
        private IWebDriver driver;

        private readonly ScenarioContext _senarioContext;

        public SeleniumDriver(ScenarioContext senarioContext)
        {
            _senarioContext = senarioContext;
        }

        public IWebDriver Setup()
        {
            driver = new ChromeDriver("D:\\work\\C#");

            _senarioContext.Set(driver, "Webdriver");

            driver.Manage().Window.Maximize();

            return driver;
        }
    }
}
