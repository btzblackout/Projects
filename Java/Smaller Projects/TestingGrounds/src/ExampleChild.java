public class ExampleChild extends Example
{
    // METHOD OVERRIDING
    // This child class contains the same method as it's parent class (Example.java) so when it is called it will
    // use this method instead of the same one in the parent class.
    public void ChildMethod(int x)
    {
        System.out.println("I am the in the child class.");
    }
}
