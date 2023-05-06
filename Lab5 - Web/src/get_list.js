
fetch('http://localhost:57099/Service1.svc/json/books')
    .then(res => {
        return res.json()
    })
    .then(data => {
        var list = document.getElementById('book_list')
        data.forEach(book => {
          let tr = document.createElement("tr")

          let tr1 = document.createElement("td")
          tr1.innerText = book.id_element
          tr.appendChild(tr1)

          let tr2 = document.createElement("td")
          tr2.innerText = book.name
          tr.appendChild(tr2)

          let tr3 = document.createElement("td")
          tr3.innerText = book.author
          tr.appendChild(tr3)

          let but_td = document.createElement("td")
          let but_obj = document.createElement("a")
          let but_i = document.createElement("i")
          but_obj.className = "btn btn-secondary btn-detail"
          but_obj.setAttribute("clicked_book_id", book.id_element)
          but_i.className = "fas fa-angle-double-right"
          but_obj.innerText = "Details"
          but_obj.appendChild(but_i)

          but_td.appendChild(but_obj)
          tr.appendChild(but_td)

          list.appendChild(tr)

        })
    })