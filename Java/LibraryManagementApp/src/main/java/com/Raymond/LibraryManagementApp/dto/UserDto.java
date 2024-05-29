/*
 * UserDto.java
 * This class is the DTO class for the User object.
 * Author: Raymond Lawson
 */

package com.Raymond.LibraryManagementApp.dto;
import lombok.Builder;
import lombok.Data;
import java.time.LocalDateTime;

@Data
@Builder
public class UserDto
{
    private int id;
    private String username;
    private String password;
    private String firstName;
    private String lastName;
    private boolean isLibrarian;
    private double balance;
    private LocalDateTime createdOn;
    private LocalDateTime updatedOn;
}
