import { html, render } from './../node_modules/lit-html/lit-html.js';
import { optionTemplate } from './templates/optionTemplate.js';

const baseUrl = 'http://localhost:3030/jsonstore/advanced/dropdown';
const selectElement = document.getElementById('menu');
let options = [];

document.querySelector('form').addEventListener('submit', addItem);

async function start() {
    const getData = await getOptions(baseUrl);
    const data = Object.values(getData);
    data.map(x => options.push(x));

    render(optionTemplate(data), selectElement);
}

start();

async function addItem(ev) {
    ev.preventDefault();
    const form = ev.target;
    const formData = new FormData(form);

    const newOptionData = {
        text: formData.get('text')
    };

    const responseNewOption = await postOptions(newOptionData, baseUrl);
    options.push(responseNewOption);

    render(optionTemplate(options), selectElement);

    // Clearing form for the next input
    form.reset();
}

async function getOptions(url) {
    const response = await fetch(url);
    if (response.ok == false) {
        throw new Error('FATAL ERROR - You broke the server man..');
    }

    return await response.json();
}

async function postOptions(text, url) {
    const response = await fetch(url, {
        method: 'post',
        headers: { 'Content-type': 'application/json' },
        body: JSON.stringify(text)
    });

    if (response.ok == false) {
        return alert('FATAL ERROR - You broke the server man..');
    }

    return await response.json();
}