package Entities;

public class Ghost extends Enemy
{
    final int health = 20;

    Ghost()
    {
    }
    public void Attack()
    {
        name = "this";
        System.out.println("I am a Entities.Ghost. Attack");
    }
}
