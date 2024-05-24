package com.gcu.data;

import java.util.List;

import com.gcu.model.Order;

public interface DataAccessInterface <T>
{
	public List<Order> findAll();
	public T findById(int id);
	public boolean create(Order order);
	public boolean update(T t);
	public boolean delete(T t);
}
