function attachEvents() {
    document.getElementById('refresh').addEventListener('click', getAll);
    document.getElementById('submit').addEventListener('click', submitMsg);

}

async function getAll() {
    const url = 'http://localhost:3030/jsonstore/messenger';
    const msgBox = document.getElementById('messages');

    const response = await fetch(url);
    const data = await response.json();

    let output = [];
    Object.values(data).forEach(({ author, content }) => {
        output.push(author + ': ' + content);
    });

    msgBox.value = output.join('\r\n');
}

async function submitMsg(message) {
    const url = 'http://localhost:3030/jsonstore/messenger';
    const authorName = document.querySelector('[name="author"]');
    const msgText = document.querySelector('[name="content"]');

    const response = await fetch(url, {
        method: 'post',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ author: authorName.value, content: msgText.value })
    });

    authorName.value = '';
    msgText.value = '';
}

attachEvents();