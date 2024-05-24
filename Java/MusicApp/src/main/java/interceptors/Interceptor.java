package interceptors;

import java.io.Serializable;

import javax.interceptor.AroundInvoke;
import javax.interceptor.InvocationContext;
import beans.LoggerClass;


public class Interceptor implements Serializable
{
	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	@AroundInvoke
	public Object intercept(InvocationContext context) throws Exception
	{
		LoggerClass log = LoggerClass.createLogger();
		log.INFO("Entering method: " + context.getMethod().getName());
		Object result = context.proceed();
		log.INFO("Leaving method: " + context.getMethod().getName());
		return result;
	}

}
