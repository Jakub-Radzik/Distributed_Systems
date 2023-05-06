
$(document).on('click', '.btn-create', function() {

    const formArray = $('form').serializeArray()

    const requestBody = 
    {
        id_element: formArray[0].value,
        name: formArray[1].value,
        author: formArray[2].value
    }
    console.log(requestBody)
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
