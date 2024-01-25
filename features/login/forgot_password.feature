@origin-ticket-002 @forgot-password
Feature: Forgot Password
    As a user
    I want to reset my password from the login page
    So that I can provide my email in order to have a reset link
    
    @automated @session
    Scenario: Request reset password success
        Given the user is not logged in
        When the user request a password reset
        Then the page should display success popup

    @automated @session
    Scenario: Back to login from forgot password page
        Given the user is not logged in
        And the user is on reset password page
        When the user click back to login button
        Then the user should be redirected to login page
