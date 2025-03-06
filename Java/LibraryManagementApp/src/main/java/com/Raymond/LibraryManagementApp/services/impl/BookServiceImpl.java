package com.Raymond.LibraryManagementApp.services.impl;

import com.Raymond.LibraryManagementApp.dto.BookDto;
import com.Raymond.LibraryManagementApp.models.Book;
import com.Raymond.LibraryManagementApp.repository.BookRepository;
import com.Raymond.LibraryManagementApp.services.BookService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.stream.Collectors;

@Service
public class BookServiceImpl implements BookService
{
    // BookRepository reference
    private BookRepository bookRepository;

    // Constructor setting repo.
    @Autowired
    public BookServiceImpl(BookRepository bookRepository)
    {
        this.bookRepository = bookRepository;
    }

    // Map the Book objects to the BookDto objects.
    private BookDto MapToBookDto(Book book)
    {
        BookDto bookDto = null;
        // Check if the book is null
        if(book != null)
        {
            bookDto = bookDto.builder()
                    .id(book.getId())
                    .title(book.getTitle())
                    .author(book.getAuthor())
                    .primaryGenre(book.getPrimaryGenre())
                    .isbn(book.getIsbn())
                    .call(book.getCall())
                    .quantity(book.getQuantity())
                    .build();
            return bookDto;
        }

        return bookDto;

    }

    @Override
    public List<BookDto> findAllBooks() {
        List<Book> books = bookRepository.findAll();

        return books.stream().map((book) -> MapToBookDto(book)).collect(Collectors.toList());
    }
}
