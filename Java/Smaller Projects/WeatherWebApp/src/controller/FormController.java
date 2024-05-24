package controller;

import java.util.List;

import javax.faces.bean.ManagedBean;
import javax.faces.bean.ViewScoped;
import javax.faces.context.FacesContext;
import javax.inject.Inject;

import beans.Weather;
import dao.WeatherDataServiceInterface;


@ManagedBean
@ViewScoped
public class FormController {
	@Inject
	WeatherDataServiceInterface<Weather> weatherDataService;
	public String getReadWeather(Weather weather) {
		List<Weather> weatherList =  weatherDataService.getConnection();
		FacesContext.getCurrentInstance().getExternalContext().getRequestMap().put("weatherList", weatherList );

		
		return "welcome.xhtml";
	}

}
