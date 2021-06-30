function pure(a, b) {
    return a + b;
}

let num = 1;
function impure(a) {
    num += a;
    return num;
}

console.log(pure(1, 2));
console.log(pure(1, 2));
console.log(pure(1, 2));
console.log(pure(1, 2));

console.log('--------');
console.log('--------');
console.log('--------');

console.log(impure(3));
console.log(impure(3));
console.log(impure(3));
console.log(impure(3));