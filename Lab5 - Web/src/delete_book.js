
$(document).on('click', '.btn-delete', function() {
    const selected_id = location.search.split('=')[1]

    console.log(selected_id)
    if (selected_id != undefined && selected_id != null) {
        fetch('http://localhost:57099/Service1.svc/json/books/' + selected_id, {
            method: 'DELETE'
        })


       //window.location.href = 'index.html'
    }
})