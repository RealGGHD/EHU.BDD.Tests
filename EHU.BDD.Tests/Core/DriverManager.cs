using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EHU.BDD.Tests.Core;

public static class DriverManager
{
    private static IWebDriver? _driver;

    public static IWebDriver GetDriver()
    {
        if (_driver == null)
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");

            _driver = new ChromeDriver(options);
        }

        return _driver;
    }

    public static void QuitDriver()
    {
        try
        {
            _driver?.Quit();
            _driver?.Dispose();
        }
        catch
        {
        }
        finally
        {
            _driver = null;
        }
    }
}