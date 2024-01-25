@ORIGIN-Ticket-008
Feature: Accesibility
As a logged user, on any page, I want to be able to toggle Use High Contrast UI from the left menu in the Account section. So the visibility for the user is way better.

    Scenario: The user should be able to activate high-contrast UI
        Given the option of changing the contrast is available through the account side menu
        When the high contrast option is enabled
        Then the website is displayed in high contrast

    Scenario: The user should be able to deactivate high-contrast UI
        Given the option of changing the contrast is available through the account side menu
        When the high contrast option is disabled
        Then the website is displayed in high contrast
