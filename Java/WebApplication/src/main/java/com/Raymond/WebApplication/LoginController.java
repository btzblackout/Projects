package com.Raymond.WebApplication;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.ResponseBody;

@Controller
public class LoginController
{
    @RequestMapping("/login")
    @ResponseBody
    public String login()
    {
        return "Login Page..";
    }
}
