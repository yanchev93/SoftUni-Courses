function solve() {
   const author = document.querySelector("#creator");
   const title = document.querySelector("#title");
   const category = document.querySelector("#category");
   const content = document.querySelector("#content");
   const createBtn = document.querySelector("body > div > div > aside > section:nth-child(1) > form > button");
   const archive = document.querySelector("body > div > div > aside > section.archive-section > ol");

   let archiveTitles = [];

   createBtn.addEventListener('click', (e) => {
      e.preventDefault();

      const article = createEl('article');

      const h1 = createEl('h1', title.value);

      const pCategory = createEl('p', 'Category:');
      const strongCategory = createEl('strong', category.value);
      pCategory.appendChild(strongCategory);

      const pCreator = createEl('p', 'Creator:');
      const strongCreator = createEl('strong', author.value);
      pCreator.appendChild(strongCreator);

      const pContent = createEl('p', content.value);

      const divButtons = createEl('div', undefined, 'buttons');
      const btnDelete = createEl('button', 'Delete', 'btn delete');
      const btnArchive = createEl('button', 'Archive', 'btn archive');
      divButtons.appendChild(btnDelete);
      divButtons.appendChild(btnArchive);

      article.appendChild(h1);
      article.appendChild(pCategory);
      article.appendChild(pCreator);
      article.appendChild(pContent);
      article.appendChild(divButtons);

      document.querySelector("body > div > div > main > section").appendChild(article);
   });

   document.addEventListener('click', (e) => {
      if (e.target.className == 'btn delete') {
         e.target.parentNode.parentNode.remove();
      } else if (e.target.className == 'btn archive') {
         const titleFromPost = e.target.parentNode.parentNode.querySelector('h1');
         const archivedTitle = titleFromPost.textContent;
         archiveTitles.push(archivedTitle);
         archiveTitles.sort((a, b) => a.localeCompare(b));

         e.target.parentNode.parentNode.remove();

         archive.innerHTML = '';
         archiveTitles.forEach(x => {
            const appendLi = document.createElement('li');
            appendLi.textContent = x;

            archive.appendChild(appendLi);
         });
      }
   });

   function createEl(type, content, className) {
      const result = document.createElement(type);
      if (content) {
         result.textContent = content;
      }

      if (className) {
         result.className = className;
      }

      return result;
   }
}
