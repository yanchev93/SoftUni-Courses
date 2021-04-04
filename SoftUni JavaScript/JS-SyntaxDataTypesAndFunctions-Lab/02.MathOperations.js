function solve(firstNum, secondNum, operator) {
    let sum;

    if (operator == '+') {
        sum = firstNum + secondNum;
    } else if (operator == '-') {
        sum = firstNum - secondNum;

    } else if (operator == '*') {
        sum = firstNum * secondNum;

    } else if (operator == '%') {
        sum = firstNum % secondNum;

    } else if (operator == '/') {
        sum = firstNum / secondNum;

    } else if (operator == '**') {
        sum = firstNum ** secondNum;
    }

    console.log(sum);
}

solve(5, 6, '+')
solve(3, 5.5, '*')