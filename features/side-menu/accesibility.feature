@origin-ticket-008 @accesibility @release-suite
Feature: Accesibility
    As a logged user, on any page, I want to be able to toggle Use High Contrast UI from the left menu in the Account section. So the visibility for the user is way better.

    @automated @side-menu
    Scenario: The user should be able to activate high-contrast UI
        Given the user is logged in
        When the high contrast option is enabled
        Then the website is displayed in high contrast

    @automated @side-menu
    Scenario: The user should be able to deactivate high-contrast UI
        Given the user is logged in
        When the high contrast option is disabled
        Then the website is not displayed in high contrast
