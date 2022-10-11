using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowProject1.Drivers;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class BrowserStepDefinitions
    {
        IWebDriver driver;
        Random rnd = new Random();
        private readonly ScenarioContext _scenarioContext;
        String test_url = "https://localhost:44348/";

        public BrowserStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given(@"I open the app")]
        public void GivenIOpenTheApp()
        {
            driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();
            
        }

        [Given(@"I login in")]
        public void GivenILoginIn()
        {
            driver.Url = test_url + "SignIn.aspx";

            IWebElement username = driver.FindElement(By.XPath("//*[@id='txtUsername']"));
            IWebElement password = driver.FindElement(By.XPath("//*[@id='txtPass']"));

            username.SendKeys("testbot");
            password.SendKeys("1234");

            driver.FindElement(By.XPath("//*[@name='btnLogin']")).Submit();
        }

        [Given(@"I select first item")]
        public void GivenISelectFirstItem()
        {
            int num = rnd.Next(1, 26);
            driver.Url = test_url + "ProductView.aspx?PID="+num;
            driver.FindElement(By.XPath("//*[@value='ADD TO CART']")).Submit();
        }

        [Given(@"I select second item")]
        public void GivenISelectSecondItem()
        {
            int num = rnd.Next(1, 26);
            driver.Url = test_url + "ProductView.aspx?PID=" + num;
            driver.FindElement(By.XPath("//*[@value='ADD TO CART']")).Submit();
        }

        [Given(@"I search for Crocin")]
        public void GivenISearchForCrocin()
        {
            driver.Url = test_url + "Products.aspx";
            IWebElement search = driver.FindElement(By.XPath("//*[@id=\"ContentPlaceHolder1_txtFilterGrid1Record\"]"));
            search.SendKeys("Crocin");
            search.Submit();
        }

        [Given(@"I add it to cart")]
        public void GivenIAddItToCart()
        {
            driver.Url = test_url + "ProductView.aspx?PID=" + 3;
            driver.FindElement(By.XPath("//*[@value='ADD TO CART']")).Submit();
        }

        [Given(@"I remove (.*) item")]
        public void GivenIRemoveItem(int p0)
        {
            driver.Url = test_url + "Cart.aspx";
            driver.FindElement(By.XPath("//*[@id='ContentPlaceHolder1_RptrCartProducts_btnRemoveCart_0']")).Submit();
        }



        [When(@"when I press Submit")]
        public void WhenWhenIPressSubmit()
        {
            driver.Url=test_url + "Payment.aspx";
            driver.FindElement(By.XPath("//*[@id='ContentPlaceHolder1_BtnPlaceNPay']")).Submit();
        }


        [Then(@"I check")]
        public void ThenICheck()
        {
            Assert.That(driver.FindElement(By.XPath("//*[@id='success']")).Text, Is.EqualTo("Congrats! Order Placed Successfully..."));

        }


        [Then(@"Crocin is added to cart")]
        public void ThenCrocinIsAddedToCart()
        {
            Assert.That(driver.FindElement(By.XPath("//*[@id='success']")).Text, Is.EqualTo("Congrats! Order Placed Successfully..."));
        }

      
     


    }
}