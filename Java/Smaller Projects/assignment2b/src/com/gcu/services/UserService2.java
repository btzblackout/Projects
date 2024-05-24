package com.gcu.services;

import java.util.ArrayList;
import java.util.List;

import javax.ws.rs.GET;
import javax.ws.rs.Path;
import javax.ws.rs.Produces;

import com.gcu.model.User;

@Path("service2")
public class UserService2 
{
	@GET
	@Path("/users")
	@Produces("application/json")
	public List<User> getUsers()
	{
		List<User> userList = new ArrayList<>();
		return userList;
	}
}
