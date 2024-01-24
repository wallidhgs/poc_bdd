Feature: Course people page
    As a logged instructor, in the course people page
    I want to have an option to remove a person from the course
    So I can revoke access to dropout person
    Ticket 010

    Scenario: Remove student
        Given the user is logged in
        And the user is on "course people page" page
        When the user remove the student
        Then the page should not display the student
