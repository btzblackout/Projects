package com.gcu.business;

import java.util.List;

import com.gcu.model.Order;

public interface OrdersBusinessInterface 
{
	public void test();
	public void init();
	public void destroy();
	public List<Order> getAllOrders();
}
