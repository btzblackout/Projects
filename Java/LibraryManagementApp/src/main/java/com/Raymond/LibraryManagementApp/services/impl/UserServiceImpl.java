/*
 * UserServiceImpl.java
 * This class implements the UserService interface and is responsible for handling custom queries to the database.
 * This class utilizes the UserDto class as well as the UserRepository class
 * Author: Raymond Lawson
 */

package com.Raymond.LibraryManagementApp.services.impl;

import com.Raymond.LibraryManagementApp.dto.UserDto;
import com.Raymond.LibraryManagementApp.models.User;
import com.Raymond.LibraryManagementApp.repository.UserRepository;
import com.Raymond.LibraryManagementApp.services.UserService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import java.util.List;
import java.util.stream.Collectors;

// Annotate this class as a service.
@Service
public class UserServiceImpl implements UserService
{
    // UserRepository reference
    private UserRepository userRepository;

    // Constructor setting the repository.
    @Autowired
    public UserServiceImpl(UserRepository userRepository) {
        this.userRepository = userRepository;
    }

    // Utilize the @Builder annotation within the UserDto class to convert the User object to a UserDto object.
    private UserDto mapToUserDto(User user)
    {
        UserDto userDto = null;
        // Check if the user is null
        if(user != null)
        {
            userDto = UserDto.builder()
                    .id(user.getId())
                    .username((user.getUsername()))
                    .password((user.getPassword()))
                    .firstName((user.getFirstName()))
                    .lastName((user.getLastName()))
                    .isLibrarian((user.isLibrarian()))
                    .balance((user.getBalance()))
                    .createdOn((user.getCreatedOn()))
                    .updatedOn((user.getUpdatedOn()))
                    .build();
        }
        // Return the UserDto object.
        return userDto;
    }

    // Implementation of the findAllUsers method.
    @Override
    public List<UserDto> findAllUsers()
    {
        // Utilize the UserRepository to grab a list of all Users.
        List<User> users = userRepository.findAll();

        // Map the list of Users to UserDto and return.
        return users.stream().map((user) -> mapToUserDto(user)).collect(Collectors.toList());
    }

    @Override
    public UserDto findByUsernameandPassword(String username, String password)
    {
        User user = userRepository.findByUsernameAndPassword(username, password);
        return mapToUserDto(user);
    }

}
