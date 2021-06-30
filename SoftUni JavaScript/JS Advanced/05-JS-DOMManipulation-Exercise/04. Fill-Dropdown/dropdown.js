function addItem() {
    const textInput = document.querySelector('#newItemText');
    const valueInput = document.querySelector('#newItemValue');
    const menuInput = document.querySelector('#menu');

    let option = document.createElement('option');
    option.textContent = textInput.value;
    option.value = valueInput.value;
    menuInput.appendChild(option);

    textInput.value = '';
    valueInput.value = '';
}