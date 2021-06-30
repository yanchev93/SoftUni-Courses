function oddNums(input){
    let output = [];

    input.forEach((el, index) => {
        if (index % 2 != 0) {
            output.push(el + el);
        }
    });

    return output.reverse().join(' ');
}

console.log(oddNums([10, 15, 20, 25]));
console.log(oddNums([3, 0, 10, 4, 7, 3]));