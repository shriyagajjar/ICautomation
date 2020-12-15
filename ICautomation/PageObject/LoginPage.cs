using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICautomation.PageObject
{
    public class LoginPage
    {
        
        public void Login(IWebDriver driver)
        {
            driver.FindElement(By.Id("UserName")).SendKeys("hari");
            driver.FindElement(By.Id("Password")).SendKeys("123123");
            driver.FindElement(By.CssSelector("input.btn.btn-default")).Click();
        }
    }
}

