import { html, render } from '../node_modules/lit-html/lit-html.js';
import { styleMap } from '../node_modules/lit-html/directives/style-map.js';
import { cats } from './catSeeder.js';

const catTemplate = (data) => html`
<li>
    <img src="./images/${data.imageLocation}.jpg" width="250" height="250" alt="Card image cap">
    <div class="info">
        <button class="showBtn">${data.info ? 'Hide': 'Show'} status code</button>
        <div class="status" style=${styleMap(data.info ? {} : {display: 'none'})} id=${data.id}>
            <h4>Status Code: ${data.statusCode}</h4>
            <p>${data.statusMessage}</p>
        </div>
    </div>
</li>`;

const catsSection = document.getElementById('allCats');
cats.forEach(c => c.info = false)
update();

function update(){
    const ulCatTemplate = (data) => html`
    <ul @click=${onClick}>
        ${data.map(catTemplate)}
    </ul>`;

    render(ulCatTemplate(cats), catsSection);
}


function onClick(ev) {
    const elementId = ev.target.parentNode.querySelector('.status').id;
    const cat = cats.find(x =>x.id == elementId);
    cat.info = !cat.info;

    update();
}


