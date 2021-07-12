async function request(url, options) {
    const response = await fetch(url, options);
    if (response.ok == false) {
        const error = await response.json();
        alert(error.message);
        throw new Error(error.message);
    }
    const data = await response.json();
    return data;
}

async function getBooks() {
    const url = 'http://localhost:3030/jsonstore/collections/books';

    const allBooks = await request(url);

    let tBody = document.querySelector('tbody');
    while (document.querySelector('tbody').firstChild) {
        document.querySelector('tbody').firstChild.remove();
    }

    Object.entries(allBooks).forEach(book => {
        tBody.appendChild(createTable(book));
    });
}

function createTable([id, book]) {
    const result =
        e('tr', { id: id },
            e('td', {}, book.title),
            e('td', {}, book.author),
            e('td', {},
                e('button', { className: 'editBtn' }, 'Edit'),
                e('button', { className: 'deleteBtn' }, 'Delete')
            )
        );

    return result;
}

async function createBook(book) {
    const url = 'http://localhost:3030/jsonstore/collections/books';

    const result = await request(url, {
        method: 'post',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(book)
    });
}

async function updateBook(id, book) {
    const url = 'http://localhost:3030/jsonstore/collections/books/' + id;

    const result = await request(url, {
        method: 'put',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(book)
    });;

    return result;
}

async function deleteBook(id) {
    const url = 'http://localhost:3030/jsonstore/collections/books/' + id;

    const result = await request(url, {
        method: 'delete',
    });;
}

function buttonsFunctionality(ev) {
    if (ev.target.className == 'editBtn') {
        const idToUpdate = ev.target.parentNode.parentNode; // couldn't find easier method that returns the parent tr
        document.getElementById('editForm').style.display = 'block';
        document.getElementById('createForm').style.display = 'none';

        loadBookForEdit(idToUpdate.id);
    } else if (ev.target.className == 'deleteBtn') {
        const idToDelete = ev.target.parentNode.parentNode; // couldn't find easier method that returns the parent tr
        deleteBook(idToDelete.id);
        idToDelete.remove();
    }
}

async function loadBookForEdit(id) {
    const url = 'http://localhost:3030/jsonstore/collections/books/' + id;

    const response = await request(url);
    document.querySelector('#editForm [name="title"]').value = response.title;
    // [...document.querySelector('#editForm')][0].value = response.title; 
    document.querySelector('#editForm [name="author"]').value = response.author;
    // [...document.querySelector('#editForm')][1].value = response.author;
    document.querySelector('#editForm [name="id"]').value = id;

}

function run() {
    document.getElementById('loadBooks').addEventListener('click', getBooks);

    document.querySelector('#createForm').addEventListener('submit', (ev) => {
        ev.preventDefault();
        const formData = new FormData(ev.target);

        const title = formData.get('title');
        const author = formData.get('author');

        createBook({ author, title });
        ev.target.reset();

    });

    document.querySelector('#editForm').addEventListener('submit', (ev) => {
        ev.preventDefault();
        const formData = new FormData(ev.target);

        const title = formData.get('title');
        const author = formData.get('author');
        const idToUpdate = formData.get('id');

        updateBook(idToUpdate, { author, title });
        ev.target.reset();

        getBooks();

        document.getElementById('editForm').style.display = 'none';
        document.getElementById('createForm').style.display = 'block';
    });
    
    document.querySelector('table').addEventListener('click', buttonsFunctionality);
}

run();

function e(type, attributes, ...content) {
    const result = document.createElement(type);

    for (let [attr, value] of Object.entries(attributes || {})) {
        if (attr.substring(0, 2) == 'on') {
            result.addEventListener(attr.substring(2).toLocaleLowerCase(), value);
        } else {
            result[attr] = value;
        }
    }

    content = content.reduce((a, c) => a.concat(Array.isArray(c) ? c : [c]), []);

    content.forEach(e => {
        if (typeof e == 'string' || typeof e == 'number') {
            const node = document.createTextNode(e);
            result.appendChild(node);
        } else {
            result.appendChild(e);
        }
    });

    return result;
}