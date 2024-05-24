package beans;

import org.slf4j.LoggerFactory;

import javax.inject.Singleton;

import org.slf4j.Logger;
@Singleton
public class LoggerClass 
{
	private static Logger log = LoggerFactory.getLogger(LoggerClass.class);
	public static LoggerClass logger;
	private LoggerClass()
	{
		
	}
	
	public static LoggerClass createLogger()
	{
		if(logger == null)
		{
			logger = new LoggerClass();
		}
		return logger;
	}
	
	public void INFO(String msg)
	{
		log.info(msg);
	}
}
