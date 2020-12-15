using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICautomation.PageObject
{
    class OpenAdminDropdown
    {

        // comment
        
        public void ClickAdminDropdown(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//li[@class='dropdown']/a")).Click();
        }
    }
}
