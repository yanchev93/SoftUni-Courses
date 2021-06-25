function solution() {
    const inputField = document.querySelector("body > div > section:nth-child(1) > div > input[type=text]");
    const sentGifts = document.querySelector("body > div > section:nth-child(3) > ul");
    const discradedGifts = document.querySelector("body > div > section:nth-child(4) > ul");
    const listOfGifts = document.querySelector("body > div > section:nth-child(2) > ul");
    const addBtn = document.querySelector("body > div > section:nth-child(1) > div > button");

    addBtn.addEventListener('click', () => {
        let name = inputField.value;
        inputField.value = '';

        const liElement = createEl('li', name, 'gift');
        const sendBtn = createEl('button', 'Send', 'sendButton');
        const discardBtn = createEl('button', 'Discard', 'discardButton');

        liElement.appendChild(sendBtn);
        liElement.appendChild(discardBtn);

        sendBtn.addEventListener('click', () => sentGift(name, liElement));
        discardBtn.addEventListener('click', () => discardGift(name, liElement))
        listOfGifts.appendChild(liElement);

        sortGifts();

    });

    function sentGift(name, gift) {
        gift.remove();

        const el = document.createElement('li');
        el.textContent = name;

        sentGifts.appendChild(el);
    }

    function discardGift(name, gift) {
        gift.remove();

        const el = document.createElement('li');
        el.textContent = name;

        discradedGifts.appendChild(el);
    }

    function sortGifts() {
        Array.from(listOfGifts.children)
            .sort((a, b) => a.textContent.localeCompare(b.textContent))
            .forEach(g => listOfGifts.appendChild(g));
    }

    function createEl(type, content, className) {
        const result = document.createElement(type);
        if (content) {
            result.textContent = content;
        }

        if (className) {
            result.className = className;
        }

        return result;
    }
}