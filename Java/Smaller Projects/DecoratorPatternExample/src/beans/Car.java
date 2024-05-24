package beans;

import interfaces.Vehicle;

public class Car implements Vehicle
{
	private String name = "Nissan Versa";
	private double price = 20000.00;
	
	public void setName(String name)
	{
		this.name = name;
	}
	public void setPrice(double price)
	{
		this.price = price;
	}
	public String getName()
	{
		return name;
	}
	public double getPrice()
	{
		return price;
	}
	public String onSale()
	{
		return price + ", " + name;
	}

}
