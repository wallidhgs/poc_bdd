@origin-ticket-009
Feature: Add People Page
As a logged instructor, on the course people page, I want to be able to add students or teachers by email. All the students and teachers should receive the proper invitation to the course.

    Scenario: The instructor should be able to add a student
        Given the user is logged in
        And the user is on "course people page" page
        When the user click on "people" button
        And fill the add people form with "students"
        Then the page should display the "students" as pending

    Scenario: The instructor should be able to add a teacher
        Given the user is logged in
        And the user is on "course people page" page
        When the user click on "people" button
        And fill the add people form with "teachers"
        Then the page should display the "teachers" as pending

    Scenario: The instructor should be able to add a teacher assistant
        Given the user is logged in
        And the user is on "course people page" page
        When the user click on "people" button
        And fill the add people form with "teacher assistants"
        Then the page should display the "teachers assistants" as pending
