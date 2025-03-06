package com.Raymond.LibraryManagementApp.controllers;

import com.Raymond.LibraryManagementApp.dto.BookDto;

import com.Raymond.LibraryManagementApp.services.BookService;
import lombok.ToString;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;


import java.util.List;

@Controller
public class SearchController
{
    // Declare variables.
    private BookService bookService;

    // Constructors
    @Autowired
    public SearchController(BookService bookService) {
        this.bookService = bookService;
    }
    @RequestMapping("/search")
    public String Search(Model model)
    {
        List<BookDto> books = bookService.findAllBooks();
        model.addAttribute("books", books);
        System.out.println("In the regular search!");
        return "search";
    }

    @RequestMapping("/search/{id}")
    public String ViewBook(@PathVariable int id)
    {
        System.out.println(id);
        return "index";
    }
}
