@ORIGIN-Ticket-009
Feature: Remove People Page
    As a logged instructor, on the course people page, I want to be able to remove students or teachers.

    Scenario: Remove student
        Given the user is logged in
        And the user is on "course people page" page
        When the user remove the student
        Then the page should not display the student
