//const { Button } = require("../lib/bootstrap/dist/js/bootstrap.bundle");

$(function () {
    console.log("Page is ready");

    //This works for all .game-cutton elements that were initially loaded
    //but will not be bound to any dynamically created buttons.
    //$(.game-button").click(function(event) {

    //This works for any .game-button elements found on the document,
    //even if they were dynamically created.
    //The click listener is attached to the document (i.e. the body of the page)
    /*$(document).on("click", ".game-button", function (event) {
        event.preventDefault();
        //pulls the current buttonNumber from the object and sets it.
        var buttonNumber = $(this).val();
        console.log("Game button was clicked " + buttonNumber + " was clicked");
        //calls method and passes buttonNumber with it.
        doButtonUpdate(buttonNumber);
        AreAllEqual();
        
    });
    */

    $(document).bind("contextmenu", function (e) {
        e.preventDefault();
        console.log("Right click. Prevent context menu from showing.")
    });

    $(document).on("mousedown", ".game-button", function (event) {
        switch (event.which) {
            case 1:
                event.preventDefault();
                var buttonNumber = $(this).val();
                console.log("Button number " + buttonNumber + " was left clicked");
                doButtonUpdate(buttonNumber, "/button/ShowOneButton");
                break;
            case 2:
                alert('Middle mouse button is pressed');
                break;
            case 3:
                event.preventDefault();
                var buttonNumber = $(this).val();
                console.log("Button number " + buttonNumber + " was right clicked")
                doButtonUpdate(buttonNumber, "/button/RightClickShowOneButton");
                break;
            default:
                alert('Nothing');
        }
    });
});

function doButtonUpdate(buttonNumber, urlstring) {
    $.ajax({
        datatype: "json",
        method: 'POST',
        //the method to call.
        url: urlstring,
        //sets the property "buttonNumber" (method parameter for ShowOneButton) to this methods parameter buttonNumber.
        data: {
            "buttonNumber": buttonNumber
        },
        success: function (data) {
            console.log(data);
            $("#" + buttonNumber).html(data);
        }
    });
};

function AreAllEqual() {
    $.ajax({
        datatype: "text",
        method: 'GET',
        url: '/button/areAllEqual',
        success: function (data) {
            var Results = document.getElementById('Results');
            Results.innerHTML = data;
        }
    });
};