function solve() {
  const [textAreaInput, textAreaOutput] = document.querySelectorAll('textarea');
  const [generateBtn, buyBtn] = document.querySelectorAll('button');
  const table = document.querySelector('tbody');


  generateBtn.addEventListener('click', (e) => {
    let furnituresInfo = JSON.parse(textAreaInput.value);

    for (const el of furnituresInfo) {
      let tr = document.createElement('tr');
      let tdImg = document.createElement('td');
      let img = document.createElement('img');
      img.src = el.img;
      tdImg.appendChild(img);

      let tdName = document.createElement('td');
      let name = document.createElement('p');
      name.textContent = el.name;
      tdName.appendChild(name);

      let tdPrice = document.createElement('td');
      let price = document.createElement('p');
      price.textContent = el.price;
      tdPrice.appendChild(price);

      let tdDecor = document.createElement('td');
      let decor = document.createElement('p');
      decor.textContent = el.decFactor;
      tdDecor.appendChild(decor);

      let tdCheck = document.createElement('td');
      let checkBox = document.createElement('input');
      checkBox.type = 'checkbox';
      tdCheck.appendChild(checkBox);

      tr.appendChild(tdImg);
      tr.appendChild(tdName);
      tr.appendChild(tdPrice);
      tr.appendChild(tdDecor);
      tr.appendChild(tdCheck);

      table.appendChild(tr);
    };
  });

  buyBtn.addEventListener('click', (e) => {
    let checkedBoxes = Array.from(document.querySelectorAll('input[type=checkbox]:checked'));

    let output = [];
    let totalPrice = 0;
    let avrgDec = 0;

    checkedBoxes.forEach(b => {
      let name = b.parentNode.parentNode.children[1].textContent;
      let price = Number(b.parentNode.parentNode.children[2].textContent);
      let decoration = Number(b.parentNode.parentNode.children[3].textContent);

      output.push(name);
      totalPrice += price;
      avrgDec += decoration;
    });

    avrgDec /= output.length;

    textAreaOutput.value = `Bought furniture: ${output.join(', ')}\nTotal price: ${totalPrice.toFixed(2)}\nAverage decoration factor: ${avrgDec}`;
  });
}