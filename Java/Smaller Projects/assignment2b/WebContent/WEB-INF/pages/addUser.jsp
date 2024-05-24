<%@ page language="java" contentType="text/html; charset=ISO-8859-1" pageEncoding="ISO-8859-1"%>
<%@taglib uri="http://www.springframework.org/tags/form" prefix="form"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
</head>
<body>

	<form:form action = "adduser" modelAttribute = "user" method = "POST">
		<form:errors path = "*"></form:errors>
		<table>
			<tr>
				
				<td><form:label path = "firstName">First Name: </form:label><form:input   path = "firstName"></form:input></td>
			</tr>
			<tr>
				<td><form:label path = "lastName">Last Name: </form:label><form:input  path = "lastName" ></form:input></td>
			</tr>
			<tr>
				<td><form:label path = "gender">Gender: </form:label><form:radiobutton path = "gender" value = "1"></form:radiobutton>Male<form:radiobutton path = "gender" value = "2"></form:radiobutton>Female</td>
			</tr>
			<tr>
				<td><input type="submit" value="Submit"></td>
			</tr>
		</table>
	</form:form>
</body>
</html>