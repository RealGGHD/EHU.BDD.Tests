Feature: EHU website

Scenario: Open About page
    Given user is on EHU homepage
    When user clicks About tab
    Then About page should be opened

Scenario: Search
    Given user is on EHU homepage
    When user searches for "study programs"
    Then search results page should be opened

Scenario: Change language
    Given user is on EHU homepage
    When user changes language to "lt"
    Then Lithuanian version should be displayed

Scenario: Open contacts
    Given user is on EHU homepage
    When user opens contacts page
    Then contact information should be visible