using ICautomation.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ICautomation
{
    public class Tests
    {
        IWebDriver driver;
        LoginPage loginpage = new LoginPage();
        ProfilePage profilePage = new ProfilePage();
        
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
            driver.Manage().Window.Maximize();

        }

        [Test]
        public void VerifyUserIsAbletoCreateCustomer()
        {
            // login page
            loginpage.Login(driver);

            //varification for username on profile page
            profilePage.VerifyUserName(driver);

            //open customer detail page
            driver.FindElement(By.XPath("//li[@class='dropdown']/a")).Click();
            driver.FindElement(By.XPath("//a[contains(text(),'Customers')]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //create customer
            driver.FindElement(By.LinkText("Create New")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.CssSelector("#Name")).SendKeys("shri");
            driver.FindElement(By.Id("EditContactButton")).Click();

            //wait  for 10 sec (for find element)
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.SwitchTo().Frame(driver.FindElement(By.Id("contactDetailWindow_wnd_title")));

            //find locator and pass details for contact
            driver.FindElement(By.CssSelector("[id=FirstName]")).SendKeys("shri");
            driver.FindElement(By.Id("LastName")).SendKeys("Gajjar");
            driver.FindElement(By.Id("Phone")).SendKeys("89645895");

            //selct checkbox 
            driver.FindElement(By.Id("IsSameContact")).Click();

            //find Gst filed and pass the text
            driver.FindElement(By.Id("GST")).SendKeys("654");

            //submit customer detail and navigate to customer list page
            driver.FindElement(By.Id("submitButton")).Click();


        }

        
    }
}