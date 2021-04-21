function printElement(input) {
    let n = Number(input.pop());

    let output = [];
    for (let i = 0; i < input.length; i += n) {
        output.push(input[i]);
    }

    return output.join('\n');
}

console.log(printElement(['1',
    '2',
    '3',
    '4',
    '5',
    '6']
));
console.log(printElement(['dsa',
    'asd',
    'test',
    'tset',
    '2']
));