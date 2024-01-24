Feature: Forgot Password
    As a user
    I want to reset my password from the login page
    So that I can provide my email in order to have a reset link
    Ticket 001
    
    Scenario: Request reset password success
        Given the user is not logged in
        When the user request a password reset
        Then the page should display a "success" popup

    Scenario: Request reset password success
        Given the user is not logged in
        And the user is on "reset password" page
        When the user click "back to login" button
        Then the user should be redirected to "login" page
