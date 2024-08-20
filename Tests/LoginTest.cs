using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject2.Pages;

namespace TestProject2.Tests
{
    public class LoginTest
    {
        IWebDriver driver;
        public LoginTest()
        {
            driver = new ChromeDriver(@"C:\\New folder\\chromedriver-win64");

            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            Console.WriteLine("exe first");
        }

        [Fact]
        public void TestCase()
        {
            Homepage homePage = new Homepage(driver);
            homePage.ClickLogin();

            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("admin", "password");
            Assert.True(homePage.IsEmployeeDetailsExists());
            Console.WriteLine("exec later");
        }
    }
}