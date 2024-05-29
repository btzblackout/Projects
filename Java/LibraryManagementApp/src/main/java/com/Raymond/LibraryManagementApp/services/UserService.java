/*
 * UserService.java
 * This class is the interface for the User service.
 * Author: Raymond Lawson
 */

package com.Raymond.LibraryManagementApp.services;

import com.Raymond.LibraryManagementApp.dto.UserDto;

import java.util.List;

// User service interface.
public interface UserService
{
    // Return a list of all users in the database.
    List<UserDto> findAllUsers();

    UserDto findByUsernameandPassword(String username, String password);
}
