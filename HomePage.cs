using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;

namespace automation_template
{
    class HomePage : Base
    {

        public HomePage()
        {
            PageFactory.InitElements(driver, this);
        }


    }
}
