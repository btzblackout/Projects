<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>
<link href = "https://code.jquery.com/ui/1.10.4/themes/ui-lightness/jquery-ui.css" rel = "stylesheet">
<script src = "https://code.jquery.com/jquery-1.10.2.js"></script>
<script src = "https://code.jquery.com/ui/1.10.4/jquery-ui.js"></script>

 <!-- CSS -->
<style type = "text/css">
	#spinner-1, #spinner-2, #spinner-3 input {width: 100px}
</style>


<!-- Javascript -->
<script>
	$(function() 
		{
			//This activates the basic +- 1 spinner on the input.
			$( "#spinner-1" ).spinner();
			
			//This is an example of setting min and max values.
			$( "#spinner-2" ).spinner (
			{
				min: -10,
				max: 10
			});
			
			//This is an example of min, max, and the step values.
			$( "#spinner-3" ).spinner (
			{
				step: 100,
				min: -1000000,
				max: 1000000
			});
		});
</script>


</head>
<body>

<!-- HTML --> 
<div id = "example">
	<input type = "text" id = "spinner-1" value = "0" />
	Spinner Min, Max value set:
	<input type = "text" id = "spinner-2" value = "0" />
	Spinner increments/decrements in step of 100:
	<input type = "text" id = "spinner-3" value = "0" />
</div>


</body>
</html>