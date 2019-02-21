function UpdateUser() {
    alert('made it here');
    var fname = $("#FirstName").val();
    var lname = $("#LastName").val();
    var gender = $("#Gender").val();
    var phone = $("#PhoneNumber").val();
    var email = $("#Email").val();

    $.ajax({
        url: "Manage/UpdateUser",
        dataType: "json",
        data: {
            FirstName: fname,
            LastName: lname,
            Gender: gender,
            PhoneNumber: phone,
            Email: email
        }
    }).done(function(data) {
        if (data) {
            alert('yay');
        } else {
            alert('na');
        }
    });
}