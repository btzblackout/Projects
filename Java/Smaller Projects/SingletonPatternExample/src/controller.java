
public class controller 
{
	public static void main(String[]args)
	{
		//Create a single instance of Character, but the values are not set yet
		Character mycharacter = Character.createCharacter();
		
		//Attempt to create anoter instance while setting values, it does not make a new instance.
		Character mysecondcharacter = Character.createCharacter("Josh", "Small", "Blond", "blue", "male", 18);
		
		//Printing the second characters name prints null because it is the empty instance created by character one
		System.out.println(mysecondcharacter.getName());
		
		//Sets the mycharacter name
		mycharacter.setName("Paul");
		
		//Prints the character name to the screen.
		System.out.println(mycharacter.getName());
		
		//Setting the second characters name changes the single instance the of character. So from Paul to Julia
		mysecondcharacter.setName("Julia");
		
		//Because it is a single instance it will print Julia.
		System.out.println(mycharacter.getName());
	}

}
