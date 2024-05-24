package com.Raymond.DependencyInjection;

import org.springframework.context.annotation.Primary;
import org.springframework.stereotype.Component;

@Component
@Primary // This will make this bean primary when confusion occurs.
public class Pickaxe implements Tool {
    public void Use()
    {
        System.out.println("The user is mining the block.");
    }

}
