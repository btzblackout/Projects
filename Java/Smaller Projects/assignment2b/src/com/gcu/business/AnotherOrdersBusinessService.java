package com.gcu.business;

import java.util.List;

import com.gcu.model.Order;

public class AnotherOrdersBusinessService implements OrdersBusinessInterface {

	@Override
	public void test() {
		System.out.println("Hello from the AnotherOrdersBusinessService");

	}

	@Override
	public void init() {
		System.out.println("Method init from AnotherOrdersBusinessService");
		
	}

	@Override
	public void destroy() {
		System.out.println("Method destroy from AnotherOrdersBusinessService");
		
	}

	@Override
	public List<Order> getAllOrders() {
		// TODO Auto-generated method stub
		return null;
	}

}
