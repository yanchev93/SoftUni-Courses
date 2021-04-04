function solve(first, second, third) {
    let sumLength;
    let avrLength;

    let lengthOne = first.length;
    let lengthTwo = second.length;
    let lengthThree = third.length;

    sumLength = lengthOne + lengthTwo + lengthThree;

    avrLength = Math.floor(sumLength / 3);

    console.log(sumLength);
    console.log(avrLength);
}

solve('chocolate', 'ice cream', 'cake')
solve('pasta', '5', '22.3')