var header = document.getElementById('detail-header')
const selected_id = location.search.split('=')[1]

header.innerText = "Edit book #" + selected_id


fetch('http://localhost:57099/Service1.svc/json/books/' + selected_id)
    .then(res => {
        if (res.ok) {
            return res.json()
        }
        else if (res.status === 404) {
            header.innerText = "Book # " + selected_id + " does not exist"
            var card = document.getElementById('detail-outer')
            card.innerHTML = ""
            var buttondiv = document.getElementById('detail-btns')
            buttondiv.innerHTML = ""
        }
    })
    .then(data => {
        if (data) {
        console.log(data)
        var input_name = document.getElementById('input-name')
        input_name.value = data.name

        var input_author = document.getElementById('input-author')
        input_author.value = data.author
        }
    })
