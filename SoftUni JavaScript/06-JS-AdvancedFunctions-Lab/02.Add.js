let x = 0;
function solve(a) {
    return (x) => x + a;
}

const add5 = solve(5);

console.log(add5(2));
console.log(add5(3));