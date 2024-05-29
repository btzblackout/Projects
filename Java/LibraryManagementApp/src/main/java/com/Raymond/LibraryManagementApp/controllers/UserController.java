/*
 * UserController.java
 * This class is the controller class for handling users.
 * Author: Raymond Lawson
 */

package com.Raymond.LibraryManagementApp.controllers;

import com.Raymond.LibraryManagementApp.dto.UserDto;
import com.Raymond.LibraryManagementApp.services.UserService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;

import java.util.List;

@Controller
public class UserController
{
    // Declare variables.
    private UserService userService;

    // Constructors
    @Autowired
    public UserController(UserService userService) {
        this.userService = userService;
    }

    @GetMapping("/users")
    public String ListUsers(Model model)
    {
        List<UserDto> users = userService.findAllUsers();
        model.addAttribute("users", users);
        return "users-list";
    }
}
