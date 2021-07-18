async function solution() {
    const data = await getData();
    const contents = data.map(id => id._id);
    this.divsContent = {};

    for (const id of contents) {
        divsContent[id] = await getExtra(id);
    }

    data.map(createElements);
}

window.onload = solution;

async function getData() {
    const url = 'http://localhost:3030/jsonstore/advanced/articles/list';

    const response = await fetch(url);
    const data = await response.json();

    return data;
}

async function getExtra(id) {
    const response = await fetch('http://localhost:3030/jsonstore/advanced/articles/details/' + id);
    const data = await response.json();

    return data.content;
}

async function createElements({ _id, title }) {
    const accordion = e('div', { className: `accordion` });
    const btn = e('button', { className: 'button', id: _id }, 'More');
    const span = e('span', {}, title);
    const head = e('div', { className: 'head' });

    const divExtra = e('div', { className: 'extra' });
    const content = e('p', {}, this.divsContent[_id]);

    btn.addEventListener('click', (e) => {
        if (e.target.textContent == 'More') {
            divExtra.style.display = 'block'
            e.target.textContent = 'Less';
        } else {
            divExtra.style.display = 'none'
            e.target.textContent = 'More';
        }
    });

    head.appendChild(span);
    head.appendChild(btn);

    divExtra.appendChild(content);

    accordion.appendChild(head);
    accordion.appendChild(divExtra);

    document.getElementById('main').appendChild(accordion);
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