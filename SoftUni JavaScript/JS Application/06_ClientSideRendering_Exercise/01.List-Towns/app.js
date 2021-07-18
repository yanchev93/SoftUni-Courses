import { html, render } from '../node_modules/lit-html/lit-html.js';

const root = document.getElementById('root');

const ulTemplate = (data) => html`
<ul>
    ${data.map(t => html`<li>${t}</li>`)}
</ul>
`;

document.getElementById('btnLoadTowns').addEventListener('click', update);

function update(ev) {
    ev.preventDefault();

    const townsInput = document.getElementById('towns').value;
    const towns = townsInput.split(',').map(t => t.trim());

    const output = ulTemplate(towns);
    render(output, root);
}
