package beans;

import javax.faces.view.ViewScoped;
import javax.inject.Named;

@Named
@ViewScoped

public class WeatherObject 
{
	private int id, temp, percip, wind, humid;
	private String city, state, date;
	
	public WeatherObject(int id, int temp, int percip, int wind, int humid, String city, String state, String date) 
	{
		super();
		this.id = id;
		this.temp = temp;
		this.percip = percip;
		this.wind = wind;
		this.humid = humid;
		this.city = city;
		this.state = state;
		this.date = date;
	}
	public WeatherObject()
	{
		
	}
	public int getId() {
		return id;
		
	}
	public void setId(int id) {
		this.id = id;
	}
	public int getTemp() {
		return temp;
	}
	public void setTemp(int temp) {
		this.temp = temp;
	}
	public int getPercip() {
		return percip;
	}
	public void setPercip(int percip) {
		this.percip = percip;
	}
	public int getWind() {
		return wind;
	}
	public void setWind(int wind) {
		this.wind = wind;
	}
	public int getHumid() {
		return humid;
	}
	public void setHumid(int humid) {
		this.humid = humid;
	}
	public String getCity() {
		return city;
	}
	public void setCity(String city) {
		this.city = city;
	}
	public String getState() {
		return state;
	}
	public void setState(String state) {
		this.state = state;
	}
	public String getDate() {
		return date;
	}
	public void setDate(String date) {
		this.date = date;
	}

	
	
	

}
