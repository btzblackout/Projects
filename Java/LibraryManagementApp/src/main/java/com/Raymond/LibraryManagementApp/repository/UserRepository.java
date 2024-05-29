/*
 * UserRepository.java
 * This class handles CRUD operations for the User.
 * Author: Raymond Lawson
 */

package com.Raymond.LibraryManagementApp.repository;

import com.Raymond.LibraryManagementApp.models.User;
import org.springframework.data.jpa.repository.JpaRepository;

public interface UserRepository extends JpaRepository<User, Long>
{
    User findByUsernameAndPassword(String username, String password);
}
