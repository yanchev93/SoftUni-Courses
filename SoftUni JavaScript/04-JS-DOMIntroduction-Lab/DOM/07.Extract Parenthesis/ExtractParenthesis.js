function extract(content) {
    let text = document.getElementById(content).textContent;

    const regex = /\((.+?)\)/gm;

    let output = [];

    let result = regex.exec(text);

    while (result != null) {
        output.push(result[1]);
        result = regex.exec(text);
    }

    return output.join('; ');
}