Feature: Course people page
    As a logged instructor, in the course people page
    I want to add students or teachers in a batch by email
    So they can have an invitation to the course
    Ticket 009

    Scenario: Add student
        Given the user is logged in
        And the user is on "course people page" page
        When the user click on "people" button
        And fill the add people form with "students"
        Then the page should display the "students" as pending

    Scenario: Add teachers
        Given the user is logged in
        And the user is on "course people page" page
        When the user click on "people" button
        And fill the add people form with "teachers"
        Then the page should display the "teachers" as pending

    Scenario: Add teacher assistants
        Given the user is logged in
        And the user is on "course people page" page
        When the user click on "people" button
        And fill the add people form with "teacher assistants"
        Then the page should display the "teachers assistants" as pending
