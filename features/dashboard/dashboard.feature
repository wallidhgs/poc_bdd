@pending
Feature: Dashboard
    As a logged user, in the dashboard
    I want to see Published and Unpublished courses
    So I can have a simple overview and quick access to the courses
    Ticket 003

    Scenario: Display published/unpublished courses
        Given the user is logged in
        And the user is on "dashboard" page
        Then the page should display the user's published courses
        And the page should display the user's unpublished courses
