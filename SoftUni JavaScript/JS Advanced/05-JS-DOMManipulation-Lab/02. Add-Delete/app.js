function addItem() {
    const input = document.querySelector('#newItemText');
    const liElement = createElement('li', input.value);


    const deleteBtn = createElement('a', '[Delete]');
    deleteBtn.href = '#';
    deleteBtn.addEventListener('click', onClick);

    liElement.appendChild(deleteBtn);

    document.querySelector('#items').appendChild(liElement);
    input.value = '';

    function onClick(event) {
        event.target.parentNode.remove();
    }

    function createElement(type, content) {
        const element = document.createElement(type);
        element.textContent = content;
        return element;
    }
}