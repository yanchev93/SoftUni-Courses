function addItem() {
    const ulElement = document.querySelector('ul');
    const input = document.querySelector('#newItemText');

    let liElement = document.createElement('li');
    liElement.textContent = input.value;

    ulElement.appendChild(liElement);
    input.value = '';
}