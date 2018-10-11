Feature: Login Feature
As a user I want to be able to login on the webshop, so I can place an 	order

Scenario: Login as registered user
Given the user is on the homepage
When the user navigates to the loginpage
And the user enters correct username
And the user enters correct password
And the user clicks on the login button
And the user is succesfully logged in
And the user navigates to Nintendo Wii Page
And the user navigates to Music Games Page
And the user clicks on order
Then Product is added to cart 
