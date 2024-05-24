package dao;


import java.io.Serializable;
import java.sql.*;
import java.util.ArrayList;
import java.util.List;

import javax.enterprise.context.Dependent;

import org.jvnet.hk2.annotations.Service;

import beans.Music;

@Service
@Dependent
public class MusicDataAccessService implements Serializable
{
	//Variables
	private static final long serialVersionUID = 1L;
	static List<Music> musicList = new ArrayList<Music>();
	static int counter;
	
	//Pull all entries from the DB and update the application.
	public List<Music> getData()
	{
		//Clears the current list of songs for re-populating.
		musicList.clear();
		
		//Access the DB and add each song to the application.
		try 
		{
			Class.forName("com.mysql.jdbc.Driver");
			Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/music?useSSL=false", "username", "pa$$word");
			Statement st = con.createStatement();
			ResultSet rs = st.executeQuery("select * from songs");
			while(rs.next())
			{
				Music music = new Music();
				music.setId(rs.getInt(1));
				music.setSongName(rs.getString(2));
				music.setArtist(rs.getString(3));
				music.setAlbum(rs.getString(4));
				music.setReleaseDate(rs.getInt(5));
				musicList.add(music);
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
		return musicList;
	}
	
	//Create
	public void addSong(Music m)
	{
		boolean check = false;
		counter = 0;
		int sizeofList = musicList.size();
		while(check == false && counter < sizeofList)
		{
			if (musicList.get(counter).getSongName().equals(m.getSongName())) 
			{
				System.out.println("The song is already in the DB!");
				check = true;
			}
			counter++;
		}
		if(check == false) 
		{
			try 
			{
				Class.forName("com.mysql.cj.jdbc.Driver");
				Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/music", "root", "password");
				Statement st = con.createStatement();
			    st.executeUpdate("INSERT INTO `music`.`songs` (`Song Name`, `Artist`, `Album`, `Release Date`) VALUES ('"+m.getSongName()+"', '"+m.getArtist()+"', '"+m.getAlbum()+"', '"+m.getReleaseDate()+"');");
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
	
	//Retrieve 
	public Music getSong(String songName)
	{
		Music m = new Music();
		counter = 0;
		while(counter < musicList.size())
		{
			if (musicList.get(counter).getSongName() == songName) 
			{
				m = musicList.get(counter);
			}
			counter++;
		}
		return m;
	}
	
	//Update
	public static void updateSong(Music m)
	{
		try 
		{
			Class.forName("com.mysql.cj.jdbc.Driver");
			Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/music", "root", "password");
			Statement st = con.createStatement();
			st.executeUpdate("UPDATE `music`.`songs` SET `Song Name` = '" + m.getSongName() + "', `Artist` '" + m.getArtist() + "', `Album` = '" + m.getAlbum() + "', `Release Date` = '" + m.getReleaseDate() + "' WHERE (`id` = '" + m.getId() + "');");
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
	
	//Delete
	public static void removeSong(int id)
	{
		try 
		{
			Class.forName("com.mysql.cj.jdbc.Driver");
			Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/music", "root", "password");
			Statement st = con.createStatement();
			st.executeUpdate("DELETE FROM `music`.`songs` WHERE (`id` = '" + id + "');");
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
