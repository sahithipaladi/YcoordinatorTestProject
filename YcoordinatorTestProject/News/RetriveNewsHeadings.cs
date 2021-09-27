
/*
 * Project: Doing Ycoordinator test and feteching the data
 * Author:  p.sahithi
 * Date :   23/09/2021
 */
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace YcoordinatorTestProject.News
{
    public class RetriveNewsHeadings : Base.BaseClass
    {
        public static List<int> list1 = new List<int>();

        //fetching the headings from the website
        public static void NewsHeadings(IWebDriver driver)
        {
            try
            {
                //Product items
                IList<IWebElement> news = driver.FindElements(By.CssSelector("a.storylink"));
                Console.WriteLine("***************Headlines******************");
                foreach (IWebElement topic in news)
                {
                    string headLines = topic.Text;

                    Console.WriteLine(headLines);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //fetching the headingspoints from the website
        public static void Points(IWebDriver driver)
        {
            Console.WriteLine("*********Points********");
            foreach (var topic in driver.FindElements(By.XPath("//*[@class='score']")))
            {
                string points = topic.Text;
                string input = points;
                string[] numbers = Regex.Split(input, @"\D+");
                foreach (string value in numbers)
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        int i = int.Parse(value);
                        list1.Add(i);
                        Console.WriteLine("Points: {0}", i);
                    }
                }
            }
            HighestPoints();
        }
        //fetching the highestpoints  from the website
        public static void HighestPoints()
        {
            var res = list1.OrderByDescending(g => g).Take(1);
            foreach(var g in res)
            {
                Console.WriteLine("Highest Points:{0}", g);
            }
        }

        //Displaying the records of both headings and points
        public static void DisplayRecords()
        {
            try
            {

                //Product items
                IList<IWebElement> records = driver.FindElements(By.XPath("//span[@class='score']|//td[@class='title']"));
                Console.WriteLine("***********************Headlines with Points*******************");
                foreach (IWebElement topic in records)
                {
                    string headlinepoints = topic.Text;
                    Console.WriteLine(headlinepoints);
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
