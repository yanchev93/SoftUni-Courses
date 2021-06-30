function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);
   let searchField = document.querySelector('#searchField');
   const emails = document.querySelectorAll('tbody>tr');

   function onClick() {
      // let emails = document.querySelectorAll('tbody>tr>td:nth-child(2)');

      for (const email of emails) {
         if (email.textContent.toLowerCase().includes(searchField.value.toLowerCase())) {
            email.setAttribute('class','select');
         } else {
            email.removeAttribute('class');
         }
      }

      searchField.value = '';
   }
}