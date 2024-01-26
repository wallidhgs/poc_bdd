@origin-ticket-005 @pending
Feature: Course homepage
    As an logged instructor, in the course home page
    I want see the link to the section pages
    So I can easily navigate and edit the course

    @pending
    Scenario: Display edit course sections
        Given the user is logged in
        And the user is on course homepage page
        Then the page should display the <section> link

        Examples:
            | section |
            | Announcements |
            | Assignments |
