Feature: Login
    On the HomePage
    Unsigned User can see Login-Button,
    Signed User cannot see Login-Button,
    Signed User can see their name

    Scenario: Unsigned user can see login button
        Given User is Unsigned
        When User is on HomePage
        Then User can see Login-Button
