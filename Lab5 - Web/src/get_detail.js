var header = document.getElementById('detail-header')
const selected_id = location.search.split('=')[1]

header.innerText = "Edit book #" + selected_id


fetch('http://localhost:57099/Service1.svc/json/books/' + selected_id)
    .then(res => {
        return res.json()
    })
    .then(data => {
        console.log(data)
        var input_name = document.getElementById('input-name')
        input_name.value = data.name

        var input_author = document.getElementById('input-author')
        input_author.value = data.author
    })
