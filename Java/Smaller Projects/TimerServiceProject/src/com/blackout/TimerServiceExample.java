package com.blackout;

import javax.annotation.Resource;
import javax.ejb.Schedule;
import javax.ejb.Stateless;
import javax.ejb.Timeout;
import javax.ejb.TimerService;

@Stateless
public class TimerServiceExample 
{

	@Resource 
	TimerService timerService;
	
	//This method will execute every 15 seconds while the server is running.
	@Schedule(second="*/15", minute="*", hour="*") 
	public void executeTask()
	{ 
		System.out.println("This method executes every 15 seconds."); 
	}
	
	//When called this starts a ten second timer named "New timer", after the alloted time it calls the @Timeout method
	public void setTimer()
	{ 
		timerService.createTimer(10000, "New timer"); 
	}
	
	//This is called after the appropriate time has expired in the "New timer".
	@Timeout 
	public void performTask() 
	{ 
		System.out.println("This method executes every 10 seconds."); 
	}

}
