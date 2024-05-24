package controller;
import java.io.Serializable;
import java.util.List;
import javax.enterprise.context.SessionScoped;
import javax.faces.context.FacesContext;
import javax.inject.Inject;
import javax.inject.Named;
import javax.interceptor.Interceptors;

import beans.Music;
import beans.User;
import dao.SecurityDataAccessService;
import interceptors.Interceptor;
import dao.MusicDataAccessService;

@Named
@SessionScoped
@Interceptors(Interceptor.class)
public class Controller implements Serializable
{
	private static final long serialVersionUID = 1L;
	@Inject
	MusicDataAccessService mdas;
	@Inject 
	SecurityDataAccessService sdas;
	
	public String getMusicList()
	{
		List<Music> musicList = mdas.getData();
		FacesContext.getCurrentInstance().getExternalContext().getRequestMap().put("musicList", musicList );
		return "Display.xhtml";
	}
	public String addMusic(Music music)
	{
		getMusicList();
		mdas.addSong(music);
		getMusicList();
		return "Display.xhtml";
	}
	public String Login(User user)
	{
		if(sdas.checkUser(user) == true)
		{
			return "Home.xhtml";
		}
		else
		{
			return "Error.xhtml";
		}
	}
	public String Register(User user)
	{
		sdas.getUsers();
		sdas.addUser(user);
		return "index.xhtml";
	}
	

}
