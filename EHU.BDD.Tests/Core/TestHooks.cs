using Reqnroll;

namespace EHU.BDD.Tests.Core;

[Binding]
public class TestHooks
{
    [BeforeScenario]
    public void Setup()
    {
        DriverManager.GetDriver();
    }

    [AfterScenario]
    public void Cleanup()
    {
        DriverManager.QuitDriver();
    }
}