package com.Raymond.LibraryManagementApp.services;

import com.Raymond.LibraryManagementApp.dto.BookDto;
import com.Raymond.LibraryManagementApp.models.Book;

import java.util.List;

public interface BookService
{
    // Return a list of all books.
    List<BookDto> findAllBooks();
}
