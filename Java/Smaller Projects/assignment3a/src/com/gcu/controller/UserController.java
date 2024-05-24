package com.gcu.controller;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.servlet.ModelAndView;

import com.gcu.business.OrdersBusinessInterface;

@Controller
@RequestMapping("/test")
public class UserController 
{
	OrdersBusinessInterface service;
	
	@RequestMapping(path = "/TestForm", method = RequestMethod.GET)
	@ResponseBody
	public ModelAndView setOrdersService()
	{
		return new ModelAndView("TestForm");
	}
	
}
