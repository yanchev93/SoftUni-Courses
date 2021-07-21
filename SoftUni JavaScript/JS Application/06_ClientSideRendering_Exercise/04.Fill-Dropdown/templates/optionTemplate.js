import { html } from './../../node_modules/lit-html/lit-html.js';

export const optionTemplate = (data) => html`
${htmlOptions(data)}
`;

function htmlOptions(data) {
    return data.map(x => html`<option value=${x._id}>${x.text}</option>`);
}