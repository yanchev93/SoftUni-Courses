import { render } from './../node_modules/lit-html/lit-html.js';
import { allStudentsTemplate, studentTemplate } from './templates/studentsTemplate.js';

const baseUrl = 'http://localhost:3030/jsonstore/advanced/table';
const tbody = document.querySelector('tbody');
let studentsArray;

getStudentsAndRenderThem(baseUrl);

function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {
      const input = document.getElementById('searchField').value.toLowerCase();

      Object.values(studentsArray)
         .forEach(objStudent => Object.entries(objStudent).map(s => {
            if (s[1] != undefined && s[1].toLowerCase().includes(input)) {
               objStudent.classSelect = 'select';
            } else {
               objStudent.classSelect = undefined;
            }
         }));
		 

      console.log(Object.values(studentsArray));
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