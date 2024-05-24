package org.Raymond;


public class User
{
    private Pickaxe pickaxe;

    private int age;

    public Pickaxe getPickaxe() {
        return pickaxe;
    }

    public void setPickaxe(Pickaxe pickaxe) {
        this.pickaxe = pickaxe;
    }

    public int getAge() {
        return age;
    }

    public void setAge(int age) {
        this.age = age;
    }

    public User()
    {

    }

    public User(Pickaxe pickaxe) {
        this.pickaxe = pickaxe;
    }

    public void SaySomething()
    {
        System.out.println("This is from SaySomething method in the User class!");
        pickaxe.Use();
    }
}
