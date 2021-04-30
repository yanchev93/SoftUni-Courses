function sumTwoNums(input) {
    if (input.length == 1) {
        return Number(input[0]) + Number(input[0]);
    }

    let first = Number(input.shift());
    let second = Number(input.pop());

    return first + second;
}

console.log(sumTwoNums(['20', '30', '40']));