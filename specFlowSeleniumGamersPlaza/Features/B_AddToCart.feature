Feature: AddToCart Feature
As a user i want to be able to add stuff to my cart

Scenario: Add Guitar Hero To Cart
Given the user is logged in
When the user navigates to Nintendo Wii Page
And the user navigates to Music Games Page
And the user clicks on order
Then Product is added to cart 