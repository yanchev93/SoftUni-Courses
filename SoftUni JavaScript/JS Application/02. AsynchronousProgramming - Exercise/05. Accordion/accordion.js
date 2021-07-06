async function solution() {
    const data = await getData();
    createElements(data);

}

window.onload = solution;

async function getData() {
    const url = 'http://localhost:3030/jsonstore/advanced/articles/list';

    const response = await fetch(url);
    const data = await response.json();

    return data;
}

async function createElements(data) {
    Object.values(data).forEach(({ _id, title }) => {
        const accordion = e('div', { className: `accordion` });
        const btn = e('button', { className: 'button', id: _id }, 'More');
        const span = e('span', {}, title);
        const head = e('div', { className: 'head' });

        head.appendChild(span);
        head.appendChild(btn);
        accordion.appendChild(head);
        document.querySelector('#main').appendChild(accordion);
    });

}


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