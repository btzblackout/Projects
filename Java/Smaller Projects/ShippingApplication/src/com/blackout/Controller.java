package com.blackout;

import java.io.IOException;
import java.util.Iterator;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class Controller
 */
@WebServlet("/Controller")
public class Controller extends HttpServlet {
	private static final long serialVersionUID = 1L;
	int counter = 0;

    
    /**
     * @see HttpServlet#HttpServlet()
     */
    public Controller() {
        super();
        // TODO Auto-generated constructor stub
    }

    protected void processRequest(HttpServletRequest request, HttpServletResponse response) throws IOException, ServletException 
	{
    	if(Model.users.isEmpty())
    	{
    		Model.createUsers();
    	}
		String username = request.getParameter("username");
		String password = request.getParameter("password");
    	if(Model.checkStats(username, password) == true)
    	{
      		RequestDispatcher dr = request.getRequestDispatcher("landing.xhtml");
    		dr.forward(request, response);
    	}
    	else
    	{
    		RequestDispatcher dr = request.getRequestDispatcher("error.xhtml");
    		dr.forward(request, response);
    		
    	}
    	
	}
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		processRequest(request, response);
		
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		processRequest(request, response);
	}

}
