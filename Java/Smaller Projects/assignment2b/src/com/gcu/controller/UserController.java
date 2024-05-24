package com.gcu.controller;

import java.util.ArrayList;
import java.util.List;

import javax.validation.Valid;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.servlet.ModelAndView;

import com.gcu.business.OrdersBusinessInterface;
import com.gcu.model.Order;
import com.gcu.model.User;

@Controller
@RequestMapping("/user")
public class UserController 
{
	OrdersBusinessInterface service;
	List<User> userList = new ArrayList<User>();
	
	@RequestMapping(path = "/add", method = RequestMethod.GET)
	@ResponseBody
	public ModelAndView displayForm()
	{

		return new ModelAndView("addUser", "user", new User());
	}
	
	@RequestMapping(path = "/adduser", method = RequestMethod.POST)
	public ModelAndView addUser(@Valid @ModelAttribute("user" )User user, BindingResult result)
	{
		if(result.hasErrors())
		{
			return new ModelAndView("addUser", "user", user);
		}
		userList.add(user);
		return new ModelAndView("displayUsers", "list", userList);
	}
	
	@Autowired
	@RequestMapping(path = "/displayOrders", method = RequestMethod.GET)
	public ModelAndView setOrdersService(OrdersBusinessInterface srv)
	{
		List<Order> orderList = srv.getAllOrders();
		return new ModelAndView("displayOrders", "orderList", orderList);
	}
	
}
