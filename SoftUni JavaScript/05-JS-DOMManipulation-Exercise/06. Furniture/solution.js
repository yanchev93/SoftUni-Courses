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


  //table.appendChild(newFurniture);
}