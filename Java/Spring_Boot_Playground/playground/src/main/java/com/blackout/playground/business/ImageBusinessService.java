package com.blackout.playground.business;

import java.util.List;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import com.blackout.playground.data.ImageDataAccessService;
import com.blackout.playground.data.entity.ImageEntity;
import com.blackout.playground.data.entity.UserEntity;

@Service
public class ImageBusinessService implements ImageBusinessServiceInterface
{
	@Autowired
	ImageDataAccessService imageService;
	
	/**
	 * Get data on a user's Images and return all Images as a list object.
	 */
	@Override
	public List<ImageEntity> getAllImagesByUser(UserEntity userEntity)
	{
		return imageService.getAllImagesByUser(userEntity);
	}
		
	/**
	 * Add an image to the database. 
	 */
	@Override
	public boolean addImage(ImageEntity imageEntity)
	{
		return imageService.add(imageEntity);
	}
	
	/**
	 * Send a post model to the database to update its corresponding record columns. 
	 */
	@Override
	public boolean updateImage(ImageEntity imageEntity)
	{
		return imageService.update(imageEntity);	
	}

	/**
	 * Delete a post from the database by its Id. 
	 */
	@Override
	public boolean deleteImage(int imageId)
	{
			
    	
		
		return imageService.delete(imageId);		
	}

	/**
	 * Get a post by its record Id. 
	 */
	@Override
	public ImageEntity getImageById(int imageId) {
		
		return imageService.getImageById(imageId);
	}

	/**
	 * Get the last image a user uploaded.
	 */
	@Override
	public ImageEntity getLastUserImage(UserEntity userEntity)
	{
		return imageService.getLastUserImage(userEntity);
	}
}
