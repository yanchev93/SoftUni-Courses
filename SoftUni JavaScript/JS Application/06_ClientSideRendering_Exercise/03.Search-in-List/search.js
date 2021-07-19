import { render } from './../node_modules/lit-html/lit-html.js';
import { towns } from './towns.js';
import { allListTemplate } from './templates/listTemplate.js';

const townsDiv = document.getElementById('towns');
const inputField = document.getElementById('searchText');

let updatedTowns = [];
towns.map(t => {
   updatedTowns.push({ name: t, class: undefined });
});

render(allListTemplate(updatedTowns), townsDiv);


document.querySelector('button').addEventListener('click', search);
function search() {
   const inputValue = inputField.value.toLowerCase();
   if (inputValue == '') {
      return;
   }

   updatedTowns.forEach(t => {
      if (t.name.toLowerCase().includes(inputValue)) {
         t.class = 'active';
      } else {
         t.class = undefined;
      }
   });

   render(allListTemplate(updatedTowns), townsDiv);
}
