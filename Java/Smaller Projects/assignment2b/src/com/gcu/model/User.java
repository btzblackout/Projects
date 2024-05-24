package com.gcu.model;

import javax.validation.constraints.Max;
import javax.validation.constraints.Min;
import javax.validation.constraints.NotNull;
import javax.validation.constraints.Size;


public class User 
{
	@NotNull (message = "First name cannot be null!")
	@Size (min = 3, max = 20, message = "First name must be between 3 and 20 characters.")
	private String firstName;
	
	@NotNull (message = "Last name cannot be null!")
	@Size (min = 3, max = 20, message = "Last name must be between 3 and 20 characters.")
	private String lastName;
	
	@NotNull (message = "Gender cannot be null!")
	@Min (value = 1, message = "Select 1 for male.")
	@Max (value = 2, message = "Select 2 for female.")
	private int gender;
	
	public User()
	{
		
		this.firstName = "";
		this.lastName = "";
		this.gender = 1;
		
	}
	
	public User(String firstName, String lastName, int gender)
	{
		this.firstName = firstName;
		this.lastName = lastName;
		this.gender = gender;
	}
	
	public String getFirstName() {
		return firstName;
	}
	public void setFirstName(String firstName) {
		this.firstName = firstName;
	}
	public String getLastName() {
		return lastName;
	}
	public void setLastName(String lastName) {
		this.lastName = lastName;
	}
	public int getGender()
	{
		return gender;
	}
	public void setGender(int gender)
	{
		this.gender = gender;
	}
	public String getGenderConverter(int gender)
	{String returning = "error";
		if(this.gender == 1)
		{
			returning = "Male";
		}
		else
		{
			returning = "Female";
		}
		return returning;
	}
	
}
