package interceptor;

import java.io.Serializable;
import java.util.logging.Logger;

import javax.annotation.Priority;
import javax.interceptor.AroundInvoke;
import javax.interceptor.InvocationContext;
@Priority(javax.interceptor.Interceptor.Priority.APPLICATION)
public class Interceptor implements Serializable
{
	public Interceptor()
	{
		
	}
	private static final long serialVersionUID = 1L;
	private static Logger log = Logger.getLogger(Interceptor.class.getName());
	@AroundInvoke
	public Object intercept(InvocationContext context) throws Exception
	{
		log.info("Entering method: " + context.getMethod().getName());
		Object result = context.proceed();
		log.info("Leaving method: " + context.getMethod().getName());
		return result;
	}

}
