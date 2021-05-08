function search() {
   const towns = document.querySelectorAll('#towns>li');
   const input = document.querySelector('input').value.toLowerCase();
   let sum = 0;

   for (const town of towns) {
      if ((town.textContent.toLowerCase()).includes(input)) {
         town.style.fontWeight = 'bold';
         town.style.textDecoration = 'underline';
         sum += 1;
      } else {
         town.style.fontWeight = '';
         town.style.textDecoration = '';
      }
   }

   document.getElementById('result').textContent = `${sum} matches found`;
}
