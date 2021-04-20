function numbers(input) {
    let outputNegative = [];
    let outputPositive = [];

    for (let i = 0; i < input.length; i++) {
        if (input[i] < 0) {
            outputNegative.push(input[i]);
        } else {
            outputPositive.push(input[i]);
        }
    }

    outputNegative.sort((a, b) => b - a).forEach(x => console.log(x));
    outputPositive.forEach(x => console.log(x));
}

numbers([7, -2, 8, 9]);
numbers([3, -2, 0, -1])