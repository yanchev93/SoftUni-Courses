function sortNumbers(input, inputOrder) {
    let array = input;
    const order = inputOrder;

    let output = order == 'asc' ? asc(array) : desc(array);

    function asc(array) {
        let ascendingArr = array.sort((a, b) => a - b);

        return ascendingArr;
    }

    function desc(array) {
        let descendingArr = array.sort((a, b) => b - a);

        return descendingArr;
    }

    return output;
}

console.log(sortNumbers([14, 7, 17, 6, 8], 'asc'));
console.log(sortNumbers([14, 7, 17, 6, 8], 'desc'));
