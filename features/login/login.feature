@origin-ticket-001 @login @pr-builder-suite @regression-suite @release-suite
Feature: Login
    As a user with valid credentials
    I want to securely log in to the learning management system
    So I can have access to a personalized dashboard with the information about my courses

    @automated @session
    Scenario: Successful login
        Given the user is not logged in
        And the user has valid credentials
        When the user performs a log in
        Then the user should be redirected to dashboard page

    @automated @session
    Scenario: Unsuccessful login
       Given the user is not logged in
       And the user has invalid credentials
       When the user performs a log in
       Then the user should be redirected to login page
       And the page should display error popup
