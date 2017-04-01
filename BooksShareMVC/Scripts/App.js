//function searchBooks() {
    //window.location = "/View/Book/" + $("#txtSearch").val().replace(/\s+/g, '-').toLowerCase();
    //$.ajax({
    //    url: '/Home/Search',
    //    data: {keyword : $('#txtSearch').val() },
    //    type: 'post',
    //    success: function (data) {
    //        $('#stage').html(data);
    //    }
    //});
//}

//function searchTheTextbox() {
//    var keycode = (event.keyCode ? event.keyCode : event.which);
//    if (keycode === 13) {
//        window.location = "/View/Book/" + $("#txtSearch").val().replace(/\s+/g, '-').toLowerCase();
//    }
//    else {
//        return;
//    }
//}

//$('#txtSearch').keypress(function (event) {
//    var keycode = (event.keyCode ? event.keyCode : event.which);
//    if (keycode === 13) {
//        alert('You pressed a "enter" key in textbox');
//    }
//    event.stopPropagation();
//});