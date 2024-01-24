Feature: User settings page
    As a logged user, in any page
    I want to toggle Use High Contrast UI from The left menu in the account section
    So I can view page more easily
    Ticket 008

    Scenario: Activate high contrast ui
        Given the user is logged in
        And the user is on "dashboard" page
        And the user open the "account" side menu
        When the user click toggle "true" the "high contrast" check
        And the page is refreshed
        Then the page should be displayed in high contrast

    Scenario: Deactivate high contrast ui
        Given the user is logged in
        And the user is on "dashboard" page
        And the user open the "account" side menu
        When the user click toggle "false" the "high contrast" check
        And the page is refreshed
        Then the page should not be displayed in high contrast
