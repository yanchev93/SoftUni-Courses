function biggest(input) {
    let biggestNum = Number.NEGATIVE_INFINITY;

    for (let i = 0; i < input.length; i++) {
        for (let j = 0; j < input[i].length; j++) {
            const element = input[i][j];

            if (element > biggestNum) {
                biggestNum = element;
            }
        }
    }

    return biggestNum;
}

console.log(biggest([[20, 50, 10],
[8, 33, 145]]
));

console.log(biggest([[3, 5, 7, 12],
[-1, 4, 33, 2],
[8, 3, 0, 4]]
));