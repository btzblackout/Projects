package decorators;

import javax.decorator.Decorator;
import javax.decorator.Delegate;
import javax.enterprise.inject.Any;
import javax.inject.Inject;

import interfaces.Vehicle;
@Decorator
public class OnSaleDecorator implements Vehicle
{
	@Any
	@Inject
	@Delegate
	private Vehicle vehicle;
	
	public void setName(String name) {
		
	}

	public void setPrice(double price) {
		
	}

	public String getName() {
		return null;
	}

	public double getPrice() {
		return 0;
	}

	public String onSale() {
		vehicle.setPrice(vehicle.getPrice() - (vehicle.getPrice() * 0.25));
		vehicle.setName(vehicle.getName() + " ON SALE");
		return vehicle.onSale();
	}

}
