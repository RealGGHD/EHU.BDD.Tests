using EHU.BDD.Tests.Pages;
using NUnit.Framework;
using Reqnroll;

namespace EHU.BDD.Tests.Steps;

[Binding]
public class EhuSteps
{
    private readonly EhuHomePage _page = new();

    [Given("user is on EHU homepage")]
    public void GivenUserIsOnEhuHomepage()
    {
        _page.OpenEnglishHome();
    }

    [When("user clicks About tab")]
    public void WhenUserClicksAboutTab()
    {
        _page.OpenAbout();
    }

    [Then("About page should be opened")]
    public void ThenAboutPageShouldBeOpened()
    {
        Assert.That(_page.IsAboutPageOpen(), Is.True);
    }

    [When("user searches for {string}")]
    public void WhenUserSearchesFor(string query)
    {
        _page.Search(query);
    }

    [Then("search results page should be opened")]
    public void ThenSearchResultsPageShouldBeOpened()
    {
        Assert.That(_page.IsSearchResultsPageOpen(), Is.True);
    }

    [When("user changes language to {string}")]
    public void WhenUserChangesLanguageTo(string lang)
    {
        if (lang.Equals("lt", StringComparison.OrdinalIgnoreCase))
        {
            _page.ChangeLanguageToLithuanian();
        }
        else
        {
            _page.OpenEnglishHome();
        }
    }

    [Then("Lithuanian version should be displayed")]
    public void ThenLithuanianVersionShouldBeDisplayed()
    {
        Assert.That(_page.IsLithuanianPageOpen(), Is.True);
    }

    [When("user opens contacts page")]
    public void WhenUserOpensContactsPage()
    {
        _page.OpenContacts();
    }

    [Then("contact information should be visible")]
    public void ThenContactInformationShouldBeVisible()
    {
        Assert.That(_page.IsContactsPageOpen(), Is.True);
        Assert.That(_page.HasContactInfo(), Is.True);
    }
}