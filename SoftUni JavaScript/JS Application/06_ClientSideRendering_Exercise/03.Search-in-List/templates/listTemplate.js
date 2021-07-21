import { html } from './../../node_modules/lit-html/lit-html.js';
import { ifDefined } from './../../node_modules/lit-html/directives/if-defined.js';

const listTemplate = (town) => html`
    <li class=${ifDefined(town.class)}>${town.name}</li>
`;

export const allListTemplate = (towns) => html`
<ul>${towns.map(t => listTemplate(t))}</ul>
`;
