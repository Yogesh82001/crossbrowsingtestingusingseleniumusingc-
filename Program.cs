using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Set the path to the ChromeDriver executable if not in PATH
        // For example, if you placed it in the project directory
        // var driver = new ChromeDriver(@"path\to\your\chromedriver\directory");
        
        // If ChromeDriver is in PATH, you can instantiate ChromeDriver directly
        using (IWebDriver driver = new ChromeDriver())
        {
            try
            {
                // Navigate to your website
                driver.Navigate().GoToUrl("https://ua.calibre.net.in/");

                // Perform actions or assertions
                Console.WriteLine("Title of the page is: " + driver.Title);

                // Example: Find an element and interact with it
                // IWebElement element = driver.FindElement(By.Name("q"));
                // element.SendKeys("Selenium WebDriver");
                // element.Submit();

                // Wait for some time or perform other operations
                System.Threading.Thread.Sleep(100000); // Sleep for few seconds
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
            finally
            {
                // Close the browser
                //driver.Quit();
            }
        }
    }
}
