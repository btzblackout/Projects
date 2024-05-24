package dao;

import java.util.List;



public interface DataAccessInterface<T> {

	public List<T> getWeatherObjects(T t);
	
}
