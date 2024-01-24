Feature: User settings page
    As a logged user, in my settings page
    I want to see my profile details
    So I can change my information
    Ticket 007

    Scenario: Display user settings
        Given the user is logged in
        And the user is on "account settings" page
        Then the page should display the "<section>" label

        Examples:
            | section |
            | Full name |
            | Display name |
            | Sortable name |
            | Language |
            | Timezone |
