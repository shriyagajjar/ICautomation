using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICautomation.PageObject
{
    public class ProfilePage
    {
        
        public void VerifyUserName(IWebDriver driver)
        {
            string username = driver.FindElement(By.LinkText("Hello hari!")).Text;
            Assert.AreEqual(username, "Hello hari!");
        }
    }
}
