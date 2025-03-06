package com.Raymond.LibraryManagementApp.dto;

import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import lombok.Builder;
import lombok.Data;

@Data
@Builder
public class BookDto
{
    private int id;
    private String title;
    private String author;
    private String primaryGenre;
    private long isbn;
    private String call;
    private int quantity;
}
