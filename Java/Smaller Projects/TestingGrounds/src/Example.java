public class Example
{
    int x;
    // METHOD OVERLOADING
    // The same method names, but the parameter list is different.
    public void PrintStuff(int x)
    {

    }

    public void PrintStuff(int x, int y)
    {

    }

    public void ChildMethod(int x)
    {
        System.out.println("I am the in the parent class.");
    }


}
