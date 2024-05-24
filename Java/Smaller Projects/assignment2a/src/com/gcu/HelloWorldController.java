package com.gcu;

import org.springframework.stereotype.Controller;
import org.springframework.ui.ModelMap;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.servlet.ModelAndView;


@Controller
@RequestMapping("/")
public class HelloWorldController 
{
	@RequestMapping(path = "/test1", method = RequestMethod.GET)
	@ResponseBody
	public String sayHello()
	{
		return "Hello World";
	}
	
	@RequestMapping (path = "/test2", method = RequestMethod.GET)
	public String sayHello(ModelMap model)
	{
		model.addAttribute("message", "Hello Spring MVC");
		return "hello";
	}
	
	@RequestMapping(path = "/test3", method = RequestMethod.GET)
	public ModelAndView sayHello1()
	{
		ModelAndView mav = new ModelAndView();
		mav.addObject("message", "Hello World from ModelAndView");
		mav.setViewName("hello");
		
		return mav;
	}
	
	@RequestMapping(path = "/test4", method = RequestMethod.GET)
	public String sayHello( @RequestParam("message") String message, ModelMap model)
	{
		model.addAttribute("message", message);
		return "hello";
	}
	
	@RequestMapping(path = "/UI", method = RequestMethod.GET)
	public ModelAndView displayUI()
	{
		return new ModelAndView("UIExample");
	}
	
	@RequestMapping(path = "/Button", method = RequestMethod.GET)
	public ModelAndView TestingButtonUI()
	{
		return new ModelAndView("UITesting");
	}
	@RequestMapping(path = "/ProgressBar", method = RequestMethod.GET)
	public ModelAndView TestingProgressBarUI()
	{
		return new ModelAndView("ProgressBarTesting");
	}
	@RequestMapping(path = "/", method = RequestMethod.GET)
	public ModelAndView TestingSpinnerUI()
	{
		return new ModelAndView("UIExample");
	}
}
