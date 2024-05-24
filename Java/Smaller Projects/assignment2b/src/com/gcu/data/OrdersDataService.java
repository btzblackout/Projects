package com.gcu.data;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

import org.springframework.stereotype.Component;

import com.gcu.model.Order;


@Component("ordersDataService")
public class OrdersDataService<T> implements DataAccessInterface<T> 
{
	
	
	public List<Order> findAll() 
	{
		List<Order> orderList = new ArrayList<>();
		String username = "user";
		String password = "derby";
		String url = "jdbc:derby:C:\\Users\\btzla\\MyDB";
		String statement = "SELECT * FROM testapp.ORDERS";
		Connection conn = null;
		try 
		{
			
			//Load the JDBC	Driver
			Class.forName("org.apache.derby.jdbc.EmbeddedDriver").newInstance();
			
			//Get a database connection
			conn = DriverManager.getConnection(url, username, password);
			Statement st = conn.createStatement();
			ResultSet rs = st.executeQuery(statement);
			
			while(rs.next())
			{
				System.out.println("ID: " + rs.getInt("ID"));
				System.out.println("Product Name: " + rs.getString("PRODUCT_NAME"));
				System.out.println("Price: " + rs.getString("PRICE"));
				orderList.add(new Order(rs.getString("ORDER_NO"), rs.getString("PRODUCT_NAME"), rs.getFloat("PRICE"), rs.getInt("QUANTITY")));
			}
			System.out.println("Success!!");
			
			rs.close();
			
			
		} 
		catch (Exception e) 
		{
			System.out.println("Failure");
		}
		finally 
		{
		    if (conn != null) 
		    { 
		    	try 
		    	{
		    		conn.close();
		    	}
		    	catch(Exception e)
		    	{
		    		
		    	}
		    }
		} 
		return orderList;
	}


	@Override
	public T findById(int id) {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public boolean create(Order order) 
	{
		
		String username = "user";
		String password = "derby";
		String url = "jdbc:derby:C:\\Users\\btzla\\MyDB";
		boolean check = false;
		
		try 
		{
			Class.forName("org.apache.derby.jdbc.EmbeddedDriver").newInstance();
			Connection conn = DriverManager.getConnection(url, username, password);
			Statement st = conn.createStatement();

			String statement = "INSERT INTO testapp.ORDERS(ORDER_NO, PRODUCT_NAME, PRICE, QUANTITY)" + 
				"VALUES('" + order.getOrderNo() + "', '" + order.getProductName() + "', '" + order.getPrice() + "', '" + order.getQuantity();
			
			st.executeUpdate(statement);
				
			conn.close();
			check = true;
		} 
		catch (Exception e) 
		{
			
		}
		return check;
	}

	@Override
	public boolean update(T t) {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public boolean delete(T t) {
		// TODO Auto-generated method stub
		return false;
	}

}
