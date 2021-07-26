import { render } from './../node_modules/lit-html/lit-html.js';
import { allStudentsTemplate, studentTemplate } from './templates/studentsTemplate.js';

const baseUrl = 'http://localhost:3030/jsonstore/advanced/table';
const tbody = document.querySelector('tbody');
let studentsArray;

getStudentsAndRenderThem(baseUrl);

function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {
      const input = document.getElementById('searchField');
      const inputValue = input.value.toLowerCase();

      const allStudents = Object.values(studentsArray).map(s => Object.assign({}, s));
      const selectedStudents = allStudents.filter(s => Object.values(s).some(value => {
         if (value) {
            return value.toLowerCase().includes(inputValue);
         }
      }));

      selectedStudents.forEach(x => x.classSelect = 'select');
      input.value = '';
      render(allStudentsTemplate(allStudents), tbody);
   }
}

solve();

async function getStudentsAndRenderThem(url) {
   const response = await fetch(url);
   const studentsData = await response.json();
   Object.values(studentsData).forEach(x => x.classSelect = undefined);
   studentsArray = Object.assign({}, studentsData);

   render(allStudentsTemplate(Object.values(studentsArray)), tbody);
}