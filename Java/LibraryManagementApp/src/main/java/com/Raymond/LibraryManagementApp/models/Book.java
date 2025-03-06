package com.Raymond.LibraryManagementApp.models;

import jakarta.persistence.*;
import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;

// Lombok
@Data
@NoArgsConstructor
@AllArgsConstructor
@Builder

// Used for creating database table from this model.
@Entity
@Table(name ="books")
public class Book
{
    // Book ID
    // @Id + @GeneratedValue needed to set variable as primary key and auto increment.
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int id;

    private String title;
    private String author;
    private String primaryGenre;
    private long isbn;
    private String call;
    private int quantity;

}
