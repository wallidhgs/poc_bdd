@origin-ticket-007 @my-settings-page
Feature: User Settings Page
    As a logged user, on the settings page, I want to be able to see the user profile details.
    The user should be able to update the information.

    @pengin
    Scenario: Display user settings
        Given the user is logged in
        And the user is on account settings page
        Then the page should display the <section> label

        Examples:
            | section |
            | Full name |
            | Display name |
            | Sortable name |
            | Language |
            | Timezone |
