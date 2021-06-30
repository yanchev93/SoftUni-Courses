function solve(firstNum, secondNum) {
    let numOne = Number(firstNum);
    let numTwo = Number(secondNum);

    let sum = 0;

    for (let i = numOne; i <= numTwo; i++) {
        sum += i;
    }

    console.log(sum);
}

solve('1', '5')
solve('-8', '20')