/*This class is just used to test the Decorator pattern*/

package controllers;
import javax.enterprise.inject.Any;
import javax.inject.Inject;
import interfaces.Vehicle;


public class Controller 
{
	@Any
	@Inject
	static
	Vehicle vehicle;
	
	public static void main(String []args)
	{
		System.out.print(vehicle.onSale());
	}
}
