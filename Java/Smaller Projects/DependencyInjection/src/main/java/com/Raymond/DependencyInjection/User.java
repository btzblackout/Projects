package com.Raymond.DependencyInjection;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.stereotype.Component;

@Component
public class User
{
    // Field injection
    // @Autowired
    private Tool tool;

    // Constructor Injection
    //public User(Pickaxe pickaxe)
    //{
    //    this.pickaxe = pickaxe;
    //}

    // Setter Injection
    @Autowired
    @Qualifier("hatchet")
    public void setTool(Tool tool)
    {
        this.tool = tool;
    }
    public void SaySomething()
    {
        System.out.println("This is from SaySomething method in the User class!");
        tool.Use();

    }
}
