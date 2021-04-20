function solve(input){
    let first = Math.min(...input);

    let output = [];
    output.push(first);

    let index = input.indexOf(first);
    input.splice(index, 1);

    let second = Math.min(...input);

    output.push(second);

    return output.join(' ');
}

console.log(solve([30, 15, 50, 5]));
console.log(solve([3, 0, 10, 4, 7, 3]));