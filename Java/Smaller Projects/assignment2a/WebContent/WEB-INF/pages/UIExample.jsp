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

<style>
	.ui-widget-header 
      	{
      		background: #98acdc;
      		border: 1px solid #DDDDDD;
      		color: #333333;
      		font-weight: bold;
      	}
    .progress-label 
      	{
            position: absolute;
            left: 50%;
            font-weight: bold;
            text-shadow: 1px 1px 0 #fff;
        }
</style>

<script>
	$(function()
	{
		//Button
		$( "#button" ).button (
    	{
        	icons: 
            	{
                	primary: "ui-icon-power"
                },
            text: false
        });
		
		//Progress Bar
		var progressbar = $( "#progressbar" );
        progressLabel = $( ".progress-label" );
        $( "#progressbar" ).progressbar(
        {
           value: false,
           change: function() 
           {
              progressLabel.text( progressbar.progressbar( "value" ) + "%" );
           },
           
           complete: function() {
              progressLabel.text( "Completed!" );
           }
        });
        
        function progress() {
           var val = progressbar.progressbar( "value" ) || 0;
           progressbar.progressbar( "value", val + 1 );
           if ( val < 99 ) {
              setTimeout( progress, 100 );
           }
        }
        setTimeout( progress, 3000 );
        
        //Spinner
        $( "#spinner" ).spinner (
    			{
    				step: 2,
    				min: -50,
    				max: 50
    			});
	});
</script>
</head>
<body>
	<button id = "button">
         This text will popup as a tooltip.
    </button>
    <br/><br/>
    <br/><br/>
    <div id = "progressbar">
    	<div class = "progress-label">
        	This bar is loading...
        </div>
    </div>
    <br/><br/>
    <br/><br/>
    This spinner increments/decrements in a step of 2 with a min of -50 and a max of 50:
	<input type = "text" id = "spinner" value = "0" />
</body>
</html>