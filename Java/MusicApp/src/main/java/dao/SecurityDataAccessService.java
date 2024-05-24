package dao;


import beans.User;

import java.io.Serializable;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

import javax.enterprise.context.Dependent;

import org.jvnet.hk2.annotations.Service;

@Service
@Dependent
public class SecurityDataAccessService implements Serializable
{
	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	static boolean check = false;
	static List<User> userList = new ArrayList<User>();
	public void getUsers()
	{
		userList.clear();
		
		try 
		{
			Class.forName("com.mysql.jdbc.Driver");
			Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/music", "username", "pa$$word");
			Statement st = con.createStatement();
			ResultSet rs = st.executeQuery("select * from users");
			while(rs.next())
			{
				User user = new User();
				user.setId(rs.getInt(1));
				user.setUsername(rs.getString(2));
				user.setPassword(rs.getString(3));
				
				userList.add(user);
				
			}
			rs.close();
			st.close();
			con.close();
		} 
		catch (ClassNotFoundException e) 
		{
			e.printStackTrace();
		} 
		catch (Exception e)
		{
			e.printStackTrace();
		}
		
	}
	public boolean checkUser(User user)
	{		
		try 
		{
			Class.forName("com.mysql.jdbc.Driver");
			Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/music", "username", "pa$$word");
			Statement st = con.createStatement();
			ResultSet rs = st.executeQuery("select * from users");
			while(rs.next())
			{
				if(user.getUsername().equals(rs.getString(2)) && user.getPassword().equals(rs.getString(3)))
				{
					check = true;
				}
			}
			rs.close();
			st.close();
			con.close();
		} 
		catch (ClassNotFoundException e) 
		{
			e.printStackTrace();
		} 
		catch (Exception e)
		{
			e.printStackTrace();
		}
		System.out.println(check);
		return check;
	}
	public void addUser(User user)
	{
		boolean check = false;
		int counter = 0;
		int sizeofList = userList.size();
		while(check == false && counter < sizeofList)
		{
			if (userList.get(counter).getUsername().equals(user.getUsername())) 
			{
				System.out.println("The user already exists.");
				check = true;
			}
			counter++;
		}
		if(check == false) 
		{
			try 
			{
				Class.forName("com.mysql.jdbc.Driver");
				Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/music", "username", "pa$$word");
				Statement st = con.createStatement();
			    st.executeUpdate("INSERT INTO `music`.`users` (`USERNAME`, `PASSWORD`) VALUES ('"+user.getUsername()+"', '"+user.getPassword() + "');");
				st.close();
				con.close();
			} 
			catch (ClassNotFoundException e) 
			{
				e.printStackTrace();
			} 
			catch (Exception e)
			{
				e.printStackTrace();
			}
		}
	}
}
