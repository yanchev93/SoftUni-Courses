function evenPosition(array) {
    let output = [];

    for (let i = 0; i < array.length; i += 2) {
        output.push(array[i]);
    }

    return output.join(' ');
}

console.log(evenPosition(['5', '10'])); 