import { render } from './../node_modules/lit-html/lit-html.js';
import { loadPage } from './templates/loadBooks.js';

const body = document.querySelector('body');
const baseUrl = 'http://localhost:3030/jsonstore/collections/books';

load(baseUrl);

async function load(url) {
    const allBooks = await (await fetch(url)).json();

    render(loadPage(Object.values(allBooks)), body);

}


