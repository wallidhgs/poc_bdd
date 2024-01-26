@pending
Feature: Dashboard additional information
    As a logged user, in the dashboard
    I want to see to additional information
    So I can have a quick access to
    ToDo's for pending Tasks, Coming up events from my calendar, View grades
    Ticket 004

    Scenario: Display ToDos
        Given the user is logged in
        And the user is on "dashboard" page
        Then the page should display the "to do" section
        And the page should display the user's pending tasks

    Scenario: Display Coming Up
        Given the user is logged in
        And the user is on "dashboard" page
        Then the page should display the "coming up" section
        And the page should display the user's calendar next week tasks
        And the page should display the "view calendar" link

    Scenario: Display View grades
        Given the user is logged in
        And the user is on "dashboard" page
        Then the page should display the "view grades" button
