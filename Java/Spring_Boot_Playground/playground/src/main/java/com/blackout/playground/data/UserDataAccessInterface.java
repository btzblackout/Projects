package com.blackout.playground.data;

import com.blackout.playground.data.entity.UserEntity;

public interface UserDataAccessInterface
{
	public UserEntity getUserByUsername(String username);
	public String getUsernameByUserId(int userId);
	public boolean add(UserEntity userEntity);
	public boolean update(UserEntity userEntity);
	public boolean delete(UserEntity userEntity);
}
