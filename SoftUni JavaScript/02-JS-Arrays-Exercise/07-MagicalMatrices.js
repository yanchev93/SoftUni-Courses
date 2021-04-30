function solve(array) {
    let equal = true;

    for (let i = 0; i < array.length; i++) {
        let currRowSum = 0;
        let currColSum = 0;

        for (let j = 0; j < array[i].length; j++) {
            currRowSum += array[i][j];
            currColSum += array[j][i];
        }
        if (currRowSum != currColSum) {
            equal = false;
            break;
        }
    }

    return equal;
}

console.log(solve([[4, 5, 6],
[6, 5, 4],
[5, 5, 5]]
));

console.log('');

console.log(solve([[11, 32, 45],
[21, 0, 1],
[21, 1, 1]]
));

console.log('');

console.log(solve([[1, 0, 0],
[0, 0, 1],
[0, 1, 0]]
));