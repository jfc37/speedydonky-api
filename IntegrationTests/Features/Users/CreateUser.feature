﻿Feature: CreateUser
	In order to participate in Full Swing
	As a student
	I want to create an account

@user @create @golden_path
Scenario: Create a user
	Given a user ready to sign up
	When a user is created
	Then that user's details can be retrieved

@user @create @validation_error
Scenario: Create a user with missing details
	Given a user ready to sign up
	And required fields are missing
	When user is attempted to be created
	Then validation errors are returned
	And user is not created

@user @create @validation_error
Scenario: Create a user with an email address already in use
	Given an exitings user has the email address 'john@email.com'
	And a user ready to sign up
	And they provide the email address 'john@email.com'
	When user is attempted to be created
	Then validation errors are returned
	And user is not created


