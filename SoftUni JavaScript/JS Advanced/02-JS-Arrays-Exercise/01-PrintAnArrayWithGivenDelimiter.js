function printDelimiter(input) {
    let delimiter = input.pop();

    return input.join(delimiter);
}

console.log(printDelimiter(['One',
    'Two',
    'Three',
    'Four',
    'Five',
    '-']
));