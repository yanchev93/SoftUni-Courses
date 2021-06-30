function subSum(array, start, end) {
    if (Array.isArray(array) == false) {
        return NaN;
    }

    if (start < 0) {
        start = 0;
    }

    if (array.length <= end) {
        end = array.length - 1;
    }

    let sum = 0;

    array.slice(start, end + 1).forEach(x => {
        sum += Number(x);
    });

    return sum;
}

console.log(subSum([10, 20, 30, 40, 50, 60], 3, 300));
console.log(subSum([1.1, 2.2, 3.3, 4.4, 5.5], -3, 1));
console.log(subSum([10, 'twenty', 30, 40], 0, 2));
console.log(subSum([], 1, 2));
console.log(subSum('text', 0, 2));