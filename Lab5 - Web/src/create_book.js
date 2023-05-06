
$(document).on('click', '.btn-create', function() {

    const formArray = $('form').serializeArray()

    const requestBody = 
    {
        id_element: formArray[0].value,
        name: formArray[1].value,
        author: formArray[2].value
    }
    
    if (!(/^.\d+$/.test(formArray[0].value))) {
        var target = document.getElementById('error-div')
        target.innerText = "Id must be an integer!"
        return
    }
    else if (formArray[0].value < 0) {
        var target = document.getElementById('error-div')
        target.innerText = "Id can not be negative!"
        return
    }

    var target = document.getElementById('error-div')
    target.innerText = "Created successfully!"
    
    try {
    fetch('http://localhost:57099/Service1.svc/json/book', {
        method: 'POST',
        body: JSON.stringify(requestBody),
        headers: {
            'Content-Type': 'application/json'
        }
    })
    .then(res => {
        return res.json()
    })
    .then(data => {
            console.log(data)

        })
    }
    catch (error) {
        console.error(`Error during POST: ${error.message}`)
    }
})
