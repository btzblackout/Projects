package dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

import javax.ejb.Local;
import javax.ejb.LocalBean;
import javax.ejb.Stateless;
import javax.enterprise.inject.Alternative;

import beans.Weather;

@Stateless
@Local(WeatherDataServiceInterface.class)
@LocalBean
@Alternative
public class WeatherDataService implements WeatherDataServiceInterface<Weather> {
	
	@Override
	public List<Weather> getConnection()  
	{
		List<Weather> weatherList = new ArrayList<Weather>();
		
		try {
			Class.forName("com.mysql.cj.jdbc.Driver");
			Connection con =DriverManager.getConnection("jdbc:mysql://localhost:3306/weatherapp", "root", "password");
			Statement st = con.createStatement();
			ResultSet rs = st.executeQuery("select * from data");
				while(rs.next())
				{
					Weather wo = new Weather();
					wo.setId(rs.getInt(1));
					wo.setTemp(rs.getInt(2));
					wo.setPercip(rs.getInt(3));
					wo.setWind(rs.getInt(4));
					wo.setHumid(rs.getInt(5));
					wo.setCity(rs.getString(6));
					wo.setState(rs.getString(7));
					wo.setDate(rs.getString(8));
					
					weatherList.add(wo);
					
				}
				
				rs.close();
				st.close();
				con.close();
				
		} catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		catch ( Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return weatherList;
	}
	
}
