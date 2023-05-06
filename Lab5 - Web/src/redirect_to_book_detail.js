
$(document).on('click', '.btn-detail', function() {
    var book_id = $(this).attr("clicked_book_id");
    console.log(book_id)
    if (book_id != undefined && book_id != null) {
        window.location.href = 'details.html?id=' + book_id
    }
})