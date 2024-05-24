package com.gcu.business;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;

import com.gcu.data.OrdersDataService;
import com.gcu.model.Order;

public class OrdersBusinessService implements OrdersBusinessInterface
{
	@Autowired
	private OrdersDataService ordersDataService;
	
	public void test() {
		System.out.println("Hello from the OrdersBusinessService");

	}

	public void init() {
		System.out.println("Method init from OrdersBusinessService");
		
	}

	public void destroy() {
		System.out.println("Method destroy from OrdersBusinessService");
		
	}


	public List<Order> getAllOrders() {
		ordersDataService.findAll();
		return null;
	}
	


}
