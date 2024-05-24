package com.blackout;

import java.util.ArrayList;
import java.util.List;


public class Model 
{
	static List<Users> users = new ArrayList<Users>();
	static Users placeholderUser = new Users();
	public static void createUsers()
	{
		users.add(new Users("admin", "password"));
		users.add(new Users("user1", "password1"));
		users.add(new Users("user2", "password2"));
		users.add(new Users("user3", "password3"));
	}
	public static boolean checkStats(String username, String password)
	{
		boolean check = false;
		int max = 0;
		while(max < users.size())
		{
			if(users.get(max).getUsername().equals(username) && users.get(max).getPassword().equals(password))
			{
				check = true;
				placeholderUser = users.get(max);
			}
			max++;
		}
		return check;
	}
}
