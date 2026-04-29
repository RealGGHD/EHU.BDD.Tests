using EHU.BDD.Tests.Core;
using OpenQA.Selenium;

namespace EHU.BDD.Tests.Pages;

public class BasePage
{
    protected readonly IWebDriver driver;

    public BasePage()
    {
        driver = DriverManager.GetDriver();
    }

    protected void NavigateTo(string url)
    {
        driver.Navigate().GoToUrl(url);
    }

    protected string GetUrl()
    {
        return driver.Url;
    }

    protected string GetPageSource()
    {
        return driver.PageSource;
    }
}