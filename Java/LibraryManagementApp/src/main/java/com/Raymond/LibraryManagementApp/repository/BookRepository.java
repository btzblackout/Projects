package com.Raymond.LibraryManagementApp.repository;

import com.Raymond.LibraryManagementApp.models.Book;
import org.springframework.data.jpa.repository.JpaRepository;

public interface BookRepository extends JpaRepository<Book, Long>
{
    
}
