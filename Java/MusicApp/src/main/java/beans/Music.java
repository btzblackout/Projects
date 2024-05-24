package beans;
import java.io.Serializable;

import javax.faces.view.ViewScoped;
import javax.inject.Named;
import javax.interceptor.Interceptors;

import interceptors.Interceptor;
import jakarta.xml.bind.annotation.XmlRootElement;

@XmlRootElement
@Named
@ViewScoped
@Interceptors(Interceptor.class)
public class Music implements Serializable
{

	private static final long serialVersionUID = 1L;
	private int id;
	private String songName, artist, album;
	private int releaseDate;
	public Music()
	{
	}
	public Music(String songName, String artist, String album, int releaseDate) 
	{
		super();
		this.songName = songName;
		this.artist = artist;
		this.album = album;
		this.releaseDate = releaseDate;
	}
	public String getSongName() 
	{
		return songName;
	}
	public void setSongName(String songName) 
	{
		this.songName = songName;
	}
	public String getArtist() 
	{
		return artist;
	}
	public void setArtist(String artist) 
	{
		this.artist = artist;
	}
	public String getAlbum() 
	{
		return album;
	}
	public void setAlbum(String album) 
	{
		this.album = album;
	}
	public int getReleaseDate() 
	{
		return releaseDate;
	}
	public void setReleaseDate(int releaseDate) 
	{
		this.releaseDate = releaseDate;
	}
	public int getId()
	{
		return id;
	}
	public void setId(int id)
	{
		this.id = id;
	}
}
