package dao;

import java.io.Serializable;
import java.sql.*;
import java.util.ArrayList;
import java.util.List;

import javax.ejb.Local;
import javax.ejb.LocalBean;
import javax.ejb.Stateless;
import javax.enterprise.inject.Alternative;

import beans.WeatherObject;

@Stateless
@Local(DataAccessInterface.class)
@LocalBean
@Alternative
public class Model implements DataAccessInterface<WeatherObject> 
{

	@Override
	public List<WeatherObject> getWeatherObjects(WeatherObject t) {
		
		List<WeatherObject> listResult = new ArrayList<WeatherObject>();
		
		listResult.add(new WeatherObject(1, 80, 40, 50, 50, "Houston", "Texas", "May 01 2020"));
		listResult.add(new WeatherObject(1, 80, 40, 50, 50, "Pheonix", "AZ", "May 01 2020"));
		return listResult;
	}
//	static List<WeatherObject> weatherObjectList = new ArrayList<>();
//	private static final long serialVersionUID = 1L;
//	
//	
//	public static void AccessDatabase() throws ClassNotFoundException, SQLException
//	{
//		
//		Class.forName("com.mysql.jdbc.Driver");
//		Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/weatherapp", "root", "password");
//		Statement st = con.createStatement();
//		ResultSet rs = st.executeQuery("select * from data");
//		while(rs.next())
//		{
//			WeatherObject wo = new WeatherObject();
//			wo.setId(rs.getInt(1));
//			wo.setTemp(rs.getInt(2));
//			wo.setPercip(rs.getInt(3));
//			wo.setWind(rs.getInt(4));
//			wo.setHumid(rs.getInt(5));
//			wo.setCity(rs.getString(6));
//			wo.setState(rs.getString(7));
//			wo.setDate(rs.getString(8));
//			
//			weatherObjectList.add(wo);
//		}
//		rs.close();
//		st.close();
//		con.close();
//	}
}
