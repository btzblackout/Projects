package com.Raymond.DependencyInjection;

import org.springframework.stereotype.Component;

@Component
public class Hatchet implements Tool {
    public void Use()
    {
        System.out.println("The user is chopping the tree.");
    }

}
