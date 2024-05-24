package controller;

import java.util.List;

import javax.faces.bean.ManagedBean;
import javax.faces.bean.ViewScoped;
import javax.faces.context.FacesContext;
import javax.inject.Inject;

import beans.WeatherObject;
import dao.DataAccessInterface;


@ManagedBean
@ViewScoped
public class FormController 
{
	
	@Inject
	DataAccessInterface<WeatherObject> weatherService;
	
	public String getWeatherData(WeatherObject wo)
	{
		List<WeatherObject> listResult =weatherService.getWeatherObjects(wo);
		FacesContext.getCurrentInstance().getExternalContext().getRequestMap().put("listResult", listResult);
		return "Display.xhtml";
	}

}
