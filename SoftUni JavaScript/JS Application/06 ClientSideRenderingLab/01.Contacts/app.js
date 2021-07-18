import { html, render } from './node_modules/lit-html/lit-html.js';
import { contacts } from './contacts.js';

const cardTemplate = (data) => html`
<div class="contact card">
    <div>
        <i class="far fa-user-circle gravatar"></i>
    </div>
    <div class="info">
        <h2>Name: ${data.name}</h2>
        <button @click=${showInfo}>Click me for more</button>
        <div style="display:none" id="hiddenBtn">
            <button @click=${onClick} class="detailsBtn">Details</button>
        </div>

        <div class="details" id=${data.id}>
            <p>Phone number: ${data.phoneNumber}</p>
            <p>Email: ${data.email}</p>
            <a href='https://www.google.bg/'> Click me</a>
        </div>
    </div>
</div>
    `;

const myContacts = document.querySelector('#contacts');
const result = contacts.map(cardTemplate);


render(result, myContacts);

function onClick(e) {
    const details = e.target.parentNode.parentNode.querySelector('.details');
    if (details.style.display == 'block') {
        details.style.display = 'none';
    } else {
        details.style.display = 'block';
    }
}

// Just testing

function showInfo(e) {
    const link = e.target.parentNode.querySelector('#hiddenBtn');
    if (link.style.display == 'inline') {
        link.style.display = 'none';
    } else {
        link.style.display = 'inline';
    }
}
