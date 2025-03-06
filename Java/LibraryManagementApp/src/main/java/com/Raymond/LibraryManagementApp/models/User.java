/*
 * User.java
 * This class is the User model class.
 * Author: Raymond Lawson
 */

package com.Raymond.LibraryManagementApp.models;

import jakarta.persistence.*;
import lombok.*;
import org.hibernate.annotations.CreationTimestamp;
import org.hibernate.annotations.UpdateTimestamp;
import java.time.LocalDateTime;
import java.util.List;

// Lombok
@Data
@NoArgsConstructor
@AllArgsConstructor
@Builder

// Used for creating a database table from this model.
@Entity
@Table(name = "users")
public class User
{
    // Declare variables.

    // User ID
    // @Id + @GeneratedValue needed to set variable as primary key and auto increment.
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int id;

    private String username;
    private String password;
    private String firstName;
    private String lastName;
    private boolean isLibrarian;
    private double balance;

    // Annotations to automatically get the timestamps.
    @CreationTimestamp
    private LocalDateTime createdOn;
    @UpdateTimestamp
    private LocalDateTime updatedOn;

}
