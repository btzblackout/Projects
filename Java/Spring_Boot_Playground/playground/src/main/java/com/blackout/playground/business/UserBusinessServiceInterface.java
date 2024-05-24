package com.blackout.playground.business;

import com.blackout.playground.data.entity.UserEntity;

public interface UserBusinessServiceInterface
{
	public UserEntity getUserByUsername(String username);
	public boolean addUser(UserEntity userEntity);
	public boolean updateUser(UserEntity userEntity);
	public boolean deleteUser(UserEntity userEntity);
}
