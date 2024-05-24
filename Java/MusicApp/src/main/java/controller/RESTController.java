package controller;

import java.util.List;

import javax.inject.Inject;

import beans.Music;
import dao.MusicDataAccessService;
import jakarta.ws.rs.GET;
import jakarta.ws.rs.POST;
import jakarta.ws.rs.Path;
import jakarta.ws.rs.PathParam;
import jakarta.ws.rs.Produces;
import jakarta.ws.rs.core.MediaType;



@Path("/song")
public class RESTController 
{
	@Inject
	MusicDataAccessService mdas;
	@GET
	@Produces(MediaType.APPLICATION_JSON)
	public List<Music> getSongs()
	{
		List<Music> songList = mdas.getData();
		return songList;
	}
	
	@GET
	@Produces(MediaType.APPLICATION_JSON)
	@Path("{songName}")
	public Music getSong(@PathParam("songName") String songName)
	{
		Music song = mdas.getSong(songName);
		return song;
	}
	
	@POST
	@Path("{songName}/{artist}/{album}/{releaseDate}")
	public void addSong(@PathParam("songName") String songName, @PathParam("artist") String artist, @PathParam("album") String album, @PathParam("releaseDate") int releaseDate)
	{
		Music song = new Music();
		song.setSongName(songName);
		song.setArtist(artist);
		song.setAlbum(album);
		song.setReleaseDate(releaseDate);
		mdas.addSong(song);
	}
	

}
