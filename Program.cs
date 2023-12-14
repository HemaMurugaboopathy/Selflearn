
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Net;

IWebDriver driver = new ChromeDriver();
driver.Navigate().GoToUrl("https://github.com/login");
IWebElement usernameTextbox = driver.FindElement(By.XPath("//*[@id=\"login_field\"]"));
usernameTextbox.SendKeys("h.prabhaharan@gmail.com");

IWebElement passwordTextbox = driver.FindElement(By.Id("password"));
passwordTextbox.SendKeys("June1@2008");

IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"login\"]/div[4]/form/div/input[13]"));
loginButton.Click();