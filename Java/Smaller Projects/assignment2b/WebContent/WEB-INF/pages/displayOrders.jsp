<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<%@ page import ="java.util.ArrayList"%>
<%@ page import ="java.util.List"%>
<%@ page import = "com.gcu.model.Order" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>
</head>
<body>
	<table border="3"> 
		<thead> 
			<tr> 
				<th>Order Number</th> 
				<th>Product Name</th> 
				<th>Price</th>  
				<th>Quantity</th>
			</tr> 
		</thead> 
		<tbody> 
			<% 
				int i = 1; 
				List<Order> list = (List) request.getAttribute("orderList"); 
			%> 
 
			<% 
				for (Order u : list) { 
			%> 
			<tr> 
				<td><%=i++%></td> 
				<td><%=u.getOrderNo()%></td> 
				<td><%=u.getProductName()%></td> 
				<td><%=u.getPrice()%> </td>
				<td><%=u.getQuantity()%> </td>
			</tr> 
			<% 
				} 
			%> 
		</tbody> 
	</table>
</body>
</html>