function solve() {
  let text = document.querySelector('#input').value;
  let output = document.querySelector('#output');
  let arrText = text.split('.').filter(p => p.length);

  if (arrText.length <= 3) {
    output.innerHTML = `<p>${text}</p>`;
  } else {
    while (arrText.length) {
      let arr = [];
      for (let i = 0; i < 3; i++) {
        arr.push(arrText.shift() + '.');
      }
      output.innerHTML += `<p>${arr.join('')}</p>`;
    }
  }
}

// function solve() {
//   let inputStr = document.getElementById('input').value;
//   let output = document.getElementById('output');

//   let input = inputStr.split('.').filter((p) => p.length > 0);

//   for (let i = 0; i < input.length; i += 3) {
//       let arr = [];
//       for (let y = 0; y < 3; y++) {
//           if (input[i + y]) {
//               arr.push(input[i + y]);
//           }
//       }
//       let paragraph = arr.join('. ') + '.';
//       output.innerHTML += `<p>${paragraph}</p>`;
//   }
// }