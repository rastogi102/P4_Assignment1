Feature: User Login

  Scenario: Valid Login
    Given I am on the login page
    When I enter valid credentials
    And I click the login button
    Then I should be logged in

  Scenario: Invalid Login
    Given I am on the login page
    When I enter invalid credentials
    And I click the login button
    Then I should see an error message

  Scenario: Missing Credentials
    Given I am on the login page
    When I click the login button
    Then I should see an error message
