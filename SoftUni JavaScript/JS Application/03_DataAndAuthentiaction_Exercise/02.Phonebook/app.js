function attachEvents() {
    document.getElementById('btnLoad').addEventListener('click', () => {
        const ulElement = document.getElementById('phonebook');
        onLoad(ulElement);
    });

    document.getElementById('btnCreate').addEventListener('click', () => {
        const person = document.getElementById('person').value;
        const phone = document.getElementById('phone').value;

        createPhone({ person, phone });

        document.getElementById('person').value = '';
        document.getElementById('phone').value = '';
    });
}

attachEvents();

async function onLoad(ulElement) {
    const url = 'http://localhost:3030/jsonstore/phonebook';

    const response = await fetch(url);
    const data = await response.json();

    while (ulElement.firstChild) {
        ulElement.removeChild(ulElement.firstChild);
    }
    
    Object.values(data).forEach(({ person, phone, _id }) => {
        const liElement = document.createElement('li');
        const deleteBtn = document.createElement('button');

        deleteBtn.textContent = 'Delete';
        deleteBtn.id = _id;
        liElement.textContent = person + ': ' + phone;
        liElement.id = _id;
        liElement.appendChild(deleteBtn);

        ulElement.appendChild(liElement);
        deleteBtn.addEventListener('click', async (ev) => {
            const url = 'http://localhost:3030/jsonstore/phonebook/' + ev.target.id;

            await fetch(url, {
                method: 'delete'
            });

            ulElement.removeChild(ev.target.parentNode);
        });
    });
}

async function createPhone(personPhone) {
    const url = 'http://localhost:3030/jsonstore/phonebook/';

    const response = await fetch(url, {
        method: 'post',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(personPhone)
    });
}