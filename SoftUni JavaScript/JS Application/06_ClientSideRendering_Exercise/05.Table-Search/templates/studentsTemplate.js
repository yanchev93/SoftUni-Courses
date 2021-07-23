import { html } from './../../node_modules/lit-html/lit-html.js';
import { ifDefined } from './../../node_modules/lit-html/directives/if-defined.js';

export const studentTemplate = (student) => html`
<tr class=${ifDefined(student.classSelect)}>
    <td>${student.firstName + ' ' + student.lastName}</td>
    <td>${student.email}</td>
    <td>${student.course}</td>
</tr>
`;

export const allStudentsTemplate = (students) =>
    html`${students.map(student => html`${studentTemplate(student)}`)}`;

