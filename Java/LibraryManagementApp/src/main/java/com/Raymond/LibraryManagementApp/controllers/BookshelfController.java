package com.Raymond.LibraryManagementApp.controllers;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;

@Controller
public class BookshelfController
{
    @GetMapping("/bookshelf")
    public String Bookshelf()
    {
        return "bookshelf";
    }
}
