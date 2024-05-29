package com.Raymond.LibraryManagementApp.controllers;

import com.Raymond.LibraryManagementApp.dto.UserDto;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
public class HomeController
{
    @RequestMapping("/index")
    public String Home()
    {
        return "index";
    }
}
