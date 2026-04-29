using EHU.BDD.Tests.Core;

namespace EHU.BDD.Tests.Pages;

public class EhuHomePage : BasePage
{
    public void OpenEnglishHome()
    {
        NavigateTo(TestData.EnglishShortUrl);
    }

    public void OpenEnglishBase()
    {
        NavigateTo(TestData.EnglishBaseUrl);
    }

    public void OpenAbout()
    {
        NavigateTo($"{TestData.EnglishShortUrl}about/");
    }

    public void OpenContacts()
    {
        NavigateTo($"{TestData.EnglishShortUrl}contacts/");
    }

    public void Search(string query)
    {
        NavigateTo($"{TestData.EnglishBaseUrl}?s={Uri.EscapeDataString(query)}");
    }

    public void ChangeLanguageToLithuanian()
    {
        NavigateTo(TestData.LithuanianShortUrl);
    }

    public bool IsAboutPageOpen()
    {
        return GetUrl().Contains("about", StringComparison.OrdinalIgnoreCase);
    }

    public bool IsSearchResultsPageOpen()
    {
        return GetUrl().Contains("?s=", StringComparison.OrdinalIgnoreCase);
    }

    public bool IsLithuanianPageOpen()
    {
        var url = GetUrl();
        return url.Contains("lt.", StringComparison.OrdinalIgnoreCase) ||
               url.Contains("/lt", StringComparison.OrdinalIgnoreCase);
    }

    public bool IsContactsPageOpen()
    {
        return GetUrl().Contains("contact", StringComparison.OrdinalIgnoreCase);
    }

    public bool HasContactInfo()
    {
        var source = GetPageSource();

        return source.Contains(TestData.ContactEmailOld, StringComparison.OrdinalIgnoreCase)
               || source.Contains(TestData.ContactEmailCurrent, StringComparison.OrdinalIgnoreCase)
               || source.Contains(TestData.PhoneCountryCode, StringComparison.OrdinalIgnoreCase);
    }
}