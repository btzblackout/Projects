<%@ page language="java" contentType="text/html; charset=ISO-8859-1" pageEncoding="ISO-8859-1"%>
<%@ page import ="java.util.ArrayList"%>
<%@ page import ="java.util.List"%>
<%@ page import = "com.gcu.model.User" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
</head>
<body>
	<table border="2"> 
		<thead> 
			<tr> 
				<th>#</th> 
				<th>First Name</th> 
				<th>Last Name</th>  
				<th>Gender</th>
			</tr> 
		</thead> 
		<tbody> 
			<% 
				int i = 1; 
				List<User> list = (List) request.getAttribute("list"); 
			%> 
 
			<% 
				for (User u : list) { 
			%> 
			<tr> 
				<td><%=i++%></td> 
				<td><%=u.getFirstName()%></td> 
				<td><%=u.getLastName()%></td> 
				<td><%=u.getGenderConverter(u.getGender())%> </td>
			</tr> 
			<% 
				} 
			%> 
		</tbody> 
	</table>
</body>
</html>