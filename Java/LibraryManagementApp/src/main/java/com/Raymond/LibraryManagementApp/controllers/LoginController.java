package com.Raymond.LibraryManagementApp.controllers;

import com.Raymond.LibraryManagementApp.dto.UserDto;
import com.Raymond.LibraryManagementApp.models.User;
import com.Raymond.LibraryManagementApp.services.UserService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;

@Controller
public class LoginController
{
    private UserService userService;

    @Autowired
    public LoginController(UserService userService) {
        this.userService = userService;
    }

    // Method for loading the login page.
    @GetMapping("/login")
    public String Login(Model model)
    {
        model.addAttribute("user", new User());
        return "login";
    }

    // Method for processing user login.
    @PostMapping("/login")
    public String LoginSubmit(@ModelAttribute User user, Model model)
    {
        // Check if the user and password match what is in the DB.
        UserDto returnedUser = userService.findByUsernameandPassword(user.getUsername(), user.getPassword());
        if(returnedUser != null)
        {
            //model.addAttribute("user", returnedUser);
            return "index";
        }
        else
        {
            return "loginerror";
        }
    }

    @GetMapping("/register")
    public String Register()
    {
        return "register";
    }

    @PostMapping("/register")
    public String RegisterSubmit()
    {
        return"login";
    }
}
