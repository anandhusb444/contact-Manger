
$(document).on('click', '.delete-contact', function () {
    const contactId = $(this).data('id');
    console.log(contactId)

    if (confirm("Are you sure you want to delete this contact?")) {
        $.ajax({
            url: '/Home/DeleteContact',
            type: 'POST',
            data: { id: contactId },
            success: function (response) {
                if (response.success) {
                    alert(response.message);
                    location.reload();
                } else {
                    alert(response.message);
                }
            },
            error: function () {
                alert("Error deleting contact.");
            }
        });
    }
});
