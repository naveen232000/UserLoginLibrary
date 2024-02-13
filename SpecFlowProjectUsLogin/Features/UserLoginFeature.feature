Feature: UserLoginFeature

A short summary of the feature

@mytag
Scenario: Sucessfull UserLogin
	Given a user with valid username "naveen" and valid password "n@123"
	When the Login method is called
	Then the result should Login Success
Scenario: Unsucessfull UserLogin
	Given a user with invalid username "invalid" and invalid password "invalid"
	When the Login method is called
	Then the result should Login Failed