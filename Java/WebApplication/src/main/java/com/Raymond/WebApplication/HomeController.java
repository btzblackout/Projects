package com.Raymond.WebApplication;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.bind.annotation.RestController;

@Controller
public class HomeController
{
    @RequestMapping("/")
    @ResponseBody
    public String greet()
    {
        return "Welcome to the Web Server!";
    }
    @RequestMapping("/about")
    @ResponseBody
    public String about()
    {
        return "We don't teach, we Educate";
    }
}
