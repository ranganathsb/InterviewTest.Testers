//Complete the page as if you were going to search for the current weather in Bristol
// For the purpose of this test the assumption has been made that you have already successfully navigated to the weather page.

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
    class WeatherPage : Base
    {

		
        public WeatherPage()
        {
            PageFactory.InitElements(driver, this);
        }

 
    }
}

