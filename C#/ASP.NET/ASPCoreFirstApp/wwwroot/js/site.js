$ (function () {
    console.log("document is ready");
    $(document).on("click", ".edit-product-button", function () {
        console.log("you just clicked button number " + $(this).val());

        //fetch the product information and fill the modal form
        var productId = $(this).val();
        $.ajax({
            type: 'json',
            data: { "id": productId },
            url: "products/ShowOneProductJSON",
            success: function myfunction(data) {
                console.log(data);

                //fill the input fields in the modal
                $("#modal-input-id").val(data.id);
                $("#modal-input-name").val(data.name);
                $("#modal-input-price").val(data.price);
                $("#modal-input-description").val(data.description);
            }
        });
    });

    $("#save-button").click(function () {
        //get the values of the input fields and make a product JSON object.
        var Product = {
            "Id": $("#modal-input-id").val(),
            "Name": $("#modal-input-name").val(),
            "Price": $("#modal-input-price").val(),
            "Description": $("#modal-input-description").val()
        }
        console.log("saved:");
        console.log(Product);

        //save the updated product record in the database using the controller
        $.ajax({
            type: 'json',
            data: Product,
            url: '/products/ProcessEditReturnPartial',
            success: function (data) {
                //show the partial update for testing purposes.
                console.log(data);
                //replace the proper card with the new data.
                $("#card-number-" + Product.Id).html(data).hide().fadeIn(2000);
            }
        })
    });
});
