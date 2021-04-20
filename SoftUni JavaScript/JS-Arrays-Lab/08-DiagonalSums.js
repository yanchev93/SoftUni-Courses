function diagonal(input) {
    let firstSum = 0;
    let secondSum = 0;

    for (let i = 0; i < input.length; i++) {
        for (let j = 0; j < input[i].length; j++) {
            firstSum += input[i][i];
            secondSum += input[i][input.length - i - 1];
            break;
        }
    }

    let output = [firstSum, secondSum];

    return output.join(' ');
}

console.log(diagonal([[20, 40],
[10, 60]]
));

console.log(diagonal([[3, 5, 17],
[-1, 7, 14],
[1, -8, 89]]
));