@pending
Feature: View as student
    As an logged instructor, in the course home page
    I want to have a button to enter "student view" mode
    So I can see verify only approved sections are displayed for the course
    Ticket 006

    Scenario: Enter student view mode
        Given the user is logged in
        And the user is on "course homepage" page
        When the user click "student view" button
        Then the page should display the "<buttons>" button

        Examples:
            | buttons |
            | Reset Student |
            | Leave Student View |

    Scenario: Student view display student buttons
        Given the user is logged in
        And the user is on "course homepage" page
        When the user click "student view" button
        Then the page should display the "<buttons>" button

        Examples:
            | buttons |
            | View course stream |
            | View course calendar |
            | View course notification |

    Scenario: Student view hide instructor buttons
        Given the user is logged in
        And the user is on "course homepage" page
        When the user click "student view" button
        Then the page should not display the "<buttons>" button

        Examples:
            | buttons |
            | Import Existing Content |
            | Choose home page |
            | Course setup checklist |
            | New Announcement |
