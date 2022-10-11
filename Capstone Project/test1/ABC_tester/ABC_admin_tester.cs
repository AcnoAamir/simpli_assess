using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ABC_admin_tester
{
    public class Browser_ops
    {
        IWebDriver webDriver;
        public void Init_Browser()
        {
            webDriver = new ChromeDriver("D:\\work\\C#");
            webDriver.Manage().Window.Maximize();
        }
        public string Title
        {
            get { return webDriver.Title; }
        }
        public void Goto(string url)
        {
            webDriver.Url = url;
        }
        public void Close()
        {
            webDriver.Quit();
        }
        public IWebDriver getDriver
        {
            get { return webDriver; }
        }
    }
    class Test1_Login
    {
        Browser_ops brow = new Browser_ops();
        String test_url = "https://med20221010182523.azurewebsites.net/";
        IWebDriver driver;

        [SetUp]
        public void start_Browser()
        {
            brow.Init_Browser();
        }

        [Test]
        public void test_Browserops()
        {
            brow.Goto(test_url + "SignIn.aspx");
            System.Threading.Thread.Sleep(4000);

            driver = brow.getDriver;

            IWebElement username = driver.FindElement(By.XPath("//*[@id='txtUsername']"));
            IWebElement password = driver.FindElement(By.XPath("//*[@id='txtPass']"));

            username.SendKeys("testadmin");
            password.SendKeys("1234");
            /* Submit the Search */

            IWebElement button = driver.FindElement(By.XPath("//*[@name='btnLogin']"));

            button.Submit();


            /* Perform wait to check the output */
            System.Threading.Thread.Sleep(2000);

        }
        [TearDown]
        public void close_Browser()
        {
            brow.Close();
        }
    }

    class Test2_Add_Brand
    {
        Browser_ops brow = new Browser_ops();
        String test_url = "https://localhost:44348/";
        IWebDriver driver;

        [SetUp]
        public void start_Browser()
        {
            brow.Init_Browser();
        }

        [Test]
        public void test_Browserops()
        {
            brow.Goto(test_url + "SignIn.aspx");
            System.Threading.Thread.Sleep(4000);

            driver = brow.getDriver;

            IWebElement username = driver.FindElement(By.XPath("//*[@id='txtUsername']"));
            IWebElement password = driver.FindElement(By.XPath("//*[@id='txtPass']"));

            username.SendKeys("testadmin");
            password.SendKeys("1234");
            /* Submit the Search */

            IWebElement button = driver.FindElement(By.XPath("//*[@name='btnLogin']"));

            button.Submit();


            /* Perform wait to check the output */
            System.Threading.Thread.Sleep(2000);

            brow.Goto(test_url+ "AddBrand.aspx");

            IWebElement brand = driver.FindElement(By.XPath("//*[@id='ContentPlaceHolder1_txtBrand']"));

            brand.SendKeys("TestBrand");

            brand.Submit();

        }
        [TearDown]
        public void close_Browser()
        {
            brow.Close();
        }
    }
}