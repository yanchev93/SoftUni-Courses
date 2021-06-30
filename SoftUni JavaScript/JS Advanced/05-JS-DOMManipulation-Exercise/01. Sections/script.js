function create(words) {
   const content = document.querySelector('#content');

   let allDivs = [];
   for (const word of words) {
      // creating the div & p
      let div = document.createElement('div');
      let p = document.createElement('p');
      // setting the div & p
      p.textContent = word;
      p.style.display = 'none';
      // attaching the p to the current div
      div.appendChild(p);
      // appending the current div to the document
      document.body.appendChild(div);
      // pushing the current div to an array of all divs
      allDivs.push(div);
   }

   allDivs.forEach(d => d.addEventListener('click', onClick));

   function onClick(ev) {
      let currentParagraph = ev.target.firstChild;
      
      isVisible = currentParagraph.style == 'none';
      
      currentParagraph.style.display = isVisible ? 'none' : 'block';
   }

   allDivs.forEach(div => content.appendChild(div));
}