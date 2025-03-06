package com.example.SpringAPI.service;


import com.example.SpringAPI.api.model.User;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Optional;

@Service
public class UserService
{
    // connects to DB

    private List<User> userList;

    public UserService()
    {
        userList = new ArrayList<>();

        User user1 = new User(1, "Raymond", 32, "raymond@mail.com");
        User user2 = new User(2,"Erica", 25, "Erica@mail.com" );
        User user3 =  new User(3, "Jason", 19, "Jason@example.com");
        User user4 = new User(4, "Kaitlyn", 20, "kpretty@email.com");
        User user5 = new User(5, "Donald", 29, "dondon@myemail.com");

        userList.addAll((Arrays.asList(user1, user2, user3, user4, user5)));
    }

    public Optional<User> getUser(Integer id)
    {
        Optional optional = Optional.empty();
        for (User user: userList)
        {
            if(id == user.getId())
            {
                optional = Optional.of(user);
                return optional;
            }
        }
        return optional;
    }
}
