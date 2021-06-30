function solve(input) {
    let count = 1;
    let output = [];

    for (let i = 0; i < input.length; i++) {
        if (input[i] == 'add') {
            output.push(count)
        } else {
            output.pop();
        }

        count += 1;
    }

    return output.length == 0 ? 'Empty' : output.join('\n');
}

console.log(solve(['add',
    'add',
    'add',
    'add']
));

console.log('');

console.log(solve(['remove',
    'remove',
    'remove']

));