function extractText() {
    let liElements = document.getElementsByTagName('li');
    let input = document.getElementById('result');

    let array = [...liElements];
    array = array.map(el => el.textContent);

    input.value = array.join('\n');
}

extractText();