function extractOnlyIncreasingNums(input) {
    let minNum = Number.NEGATIVE_INFINITY;
    let output = [];

    input.reduce((acc, curr) => {
        if (minNum <= curr) {
            output.push(curr);

            minNum = curr;
        }
    },0);

    return output.length == 0 ? '' : output.join('\n');
}

console.log(extractOnlyIncreasingNums([1,
    3,
    8,
    4,
    10,
    12,
    3,
    2,
    24]
));

console.log('');

console.log(extractOnlyIncreasingNums([1,
    2,
    3,
    4]
));

console.log('');

console.log(extractOnlyIncreasingNums([20,
    3,
    2,
    15,
    6,
    1]
));