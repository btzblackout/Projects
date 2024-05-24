package com.blackout;

public class Users 
{
	// Declare variables.
	private String username
	private String password;

	// Create Constructors.
	public Users(String username, String password)
	{
		this.username = username;
		this.password = password;
	}
	public Users()
	{
		
	}

	// Getters and Setters.
	public String getUsername() {
		return username;
	}
	public void setUsername(String username) {
		this.username = username;
	}
	public String getPassword() {
		return password;
	}
	public void setPassword(String password) {
		this.password = password;
	}	
}
