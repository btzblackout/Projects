<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>
<link href = "https://code.jquery.com/ui/1.10.4/themes/ui-lightness/jquery-ui.css"
   rel = "stylesheet">
<script src = "https://code.jquery.com/jquery-1.10.2.js"></script>
<script src = "https://code.jquery.com/ui/1.10.4/jquery-ui.js"></script>
<script>
	$(function() 
		{
  			$( "#button-1, #button-2, #button-3, #button-4" ).button();
    		$( "#button-5" ).buttonset();
    		$( "#button-6" ).button (
    			{
                	icons: 
                		{
                    		primary: "ui-icon-locked"
                 		},
                 	text: false
              	});
            $( "#button-7" ).button({
                 disabled:true
              });
            $( "#button-8" ).button({
                 icons: {
                    primary: "ui-icon-gear",
                    secondary: "ui-icon-triangle-1-s"
                 }
              });
 		});
</script>
</head>
<body>
	<button id = "button-1">A button element</button>
      <input id = "button-2" type = "submit" value = "A submit button">
      <a id = "button-3" href = "">An anchor</a>
      <input type = "checkbox"  id = "button-4" >
      <label for = "button-4">Toggle</label>
      <br><br>
      <div id = "button-5">
         <input type = "checkbox" id = "check1">
         <label for = "check1">Left</label>
         <input type = "checkbox" id = "check2">
         <label for = "check2">Middle</label>
         <input type = "checkbox" id = "check3">
         <label for = "check3">Right</label>
      </div>
      <button id = "button-6">
         Button with icon only
      </button>
      <button id = "button-7">
         Button Disabled
      </button>
      <button id = "button-8">
         Button with two icons
      </button>
</body>
</html>