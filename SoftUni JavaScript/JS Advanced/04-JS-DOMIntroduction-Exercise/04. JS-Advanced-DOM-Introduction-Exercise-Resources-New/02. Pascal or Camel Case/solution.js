function solve() {
  const text = document.getElementById('text').value;
  const namingConvention = document.getElementById('naming-convention').value;
  const result = document.getElementById('result');

  let output = '';
  if (namingConvention == 'Camel Case') {
    let changeText = text.split(' ').map(word => word.toLowerCase());
    let arr = [];

    arr.push(changeText[0]);
    for (let i = 1; i < changeText.length; i++) {
      let word = changeText[i];

      word = word[0].toUpperCase() + word.substring(1);

      arr.push(word);
    }

    output = arr.join('');
  } else if (namingConvention == 'Pascal Case') {
    let changeText = text.split(' ').map(word => word.toLowerCase());
    let arr = [];

    for (let i = 0; i < changeText.length; i++) {
      let word = changeText[i];

      word = word[0].toUpperCase() + word.substring(1);

      arr.push(word);
    }

    output = arr.join('');
  } else {
    output = 'Error!';
  }

  result.textContent = output;
}