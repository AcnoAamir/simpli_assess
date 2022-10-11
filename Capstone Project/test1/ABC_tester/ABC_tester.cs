using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ABC_tester
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
    class Test1_correct_credentials
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

            username.SendKeys("testbot");
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
    class Test2_incorrect_credentials
    {
        Browser_ops brow = new Browser_ops();
        String test_url = "https://localhost:44348//";
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

            username.SendKeys("testbot");
            password.SendKeys("12345");
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

    class Test3_ViewProducts
    {
        Browser_ops brow = new Browser_ops();
        String test_url = "https://localhost:44348//";
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

            username.SendKeys("testbot");
            password.SendKeys("1234");
            /* Submit the Search */

            IWebElement button = driver.FindElement(By.XPath("//*[@name='btnLogin']"));

            button.Submit();

            brow.Goto(test_url + "Products.aspx");
            /* Perform wait to check the output */
            System.Threading.Thread.Sleep(2000);

        }
        [TearDown]
        public void close_Browser()
        {
            brow.Close();
        }
    }

    class Test4_OderProduct
    {
        Browser_ops brow = new Browser_ops();
        String test_url = "https://localhost:44348//";
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

            username.SendKeys("testbot");
            password.SendKeys("1234");
            /* Submit the Search */

            IWebElement button = driver.FindElement(By.XPath("//*[@name='btnLogin']"));

            button.Submit();


            Random rnd = new Random();
            int num = rnd.Next(1, 26);
            brow.Goto(test_url + "ProductView.aspx?PID=" + num);
            button = driver.FindElement(By.XPath("//*[@value='ADD TO CART']"));
            button.Submit();

            brow.Goto(test_url + "Cart.aspx");

            /* Perform wait to check the output */
            int c = driver.FindElements(By.XPath("//*[@value=\"Remove\"]")).Count;
            System.Diagnostics.Debug.WriteLine(c);
            if (c == 1)
            {
                driver.FindElement(By.XPath("//*[@name = 'ctl00$ContentPlaceHolder1$RptrCartProducts$ctl00$btnRemoveCart']")).Submit();

            }

            else
            {
                for (int i = 0; i < c; i++)
                {
                    brow.Goto(test_url + "Cart.aspx");
                    driver.FindElement(By.XPath("//*[@id='ContentPlaceHolder1_RptrCartProducts_btnRemoveCart_0']")).Submit();
                }
            }
            System.Threading.Thread.Sleep(10000);
        }
        [TearDown]
        public void close_Browser()
        {
            brow.Close();
        }
    }

    class Test5_OderProducts
    {
        Browser_ops brow = new Browser_ops();
        String test_url = "https://localhost:44348//";
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

            username.SendKeys("testbot");
            password.SendKeys("1234");
            /* Submit the Search */

            IWebElement button = driver.FindElement(By.XPath("//*[@name='btnLogin']"));

            button.Submit();


            Random rnd = new Random();
            int num;
            for (int i = 0; i < 10; i++)
            {
                num = rnd.Next(1, 26);

                brow.Goto(test_url + "ProductView.aspx?PID=" + num);
                button = driver.FindElement(By.XPath("//*[@value='ADD TO CART']"));
                button.Submit();
            }
            brow.Goto(test_url + "Cart.aspx");

            /* Perform wait to check the output */
            System.Threading.Thread.Sleep(2000);
            int c = driver.FindElements(By.XPath("//*[@value=\"Remove\"]")).Count;
            System.Diagnostics.Debug.WriteLine(c);
            if (c == 1)
            {
                driver.FindElement(By.XPath("//*[@name = 'ctl00$ContentPlaceHolder1$RptrCartProducts$ctl00$btnRemoveCart']")).Submit();

            }

            else
            {
                for (int i = 0; i < c; i++)
                {
                    brow.Goto(test_url + "Cart.aspx");
                    driver.FindElement(By.XPath("//*[@id='ContentPlaceHolder1_RptrCartProducts_btnRemoveCart_0']")).Submit();
                }
            }
            System.Threading.Thread.Sleep(10000);
        }
        [TearDown]
        public void close_Browser()
        {
            brow.Close();
        }
    }

    class Test6_Buynow
    {
        Browser_ops brow = new Browser_ops();
        String test_url = "https://localhost:44348//";
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

            username.SendKeys("testbot");
            password.SendKeys("1234");
            /* Submit the Search */

            IWebElement button = driver.FindElement(By.XPath("//*[@name='btnLogin']"));

            button.Submit();


            Random rnd = new Random();
            int num;
            for (int i = 0; i < 10; i++)
            {
                num = rnd.Next(1, 26);

                brow.Goto(test_url + "ProductView.aspx?PID=" + num);
                button = driver.FindElement(By.XPath("//*[@value='ADD TO CART']"));
                button.Submit();
            }
            brow.Goto(test_url + "Cart.aspx");

            /* Perform wait to check the output */
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@value='BUY NOW']")).Submit();

            System.Threading.Thread.Sleep(10000);
        }
        [TearDown]
        public void close_Browser()
        {
            brow.Close();
        }
    }

    class Test7_Order
    {
        Browser_ops brow = new Browser_ops();
        String test_url = "https://localhost:44348//";
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

            username.SendKeys("testbot");
            password.SendKeys("1234");
            /* Submit the Search */

            IWebElement button = driver.FindElement(By.XPath("//*[@name='btnLogin']"));

            button.Submit();


            Random rnd = new Random();
            int num;
            for (int i = 0; i < 10; i++)
            {
                num = rnd.Next(1, 26);

                brow.Goto(test_url + "ProductView.aspx?PID=" + num);
                button = driver.FindElement(By.XPath("//*[@value='ADD TO CART']"));
                button.Submit();
            }
            brow.Goto(test_url + "Cart.aspx");

            /* Perform wait to check the output */
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@value='BUY NOW']")).Submit();
            brow.Goto(test_url + "Payment.aspx");
            driver.FindElement(By.XPath("//*[@id=\"ContentPlaceHolder1_BtnPlaceNPay\"]")).Submit();
            System.Threading.Thread.Sleep(10000);
        }
        [TearDown]
        public void close_Browser()
        {
            brow.Close();
        }
    }
}