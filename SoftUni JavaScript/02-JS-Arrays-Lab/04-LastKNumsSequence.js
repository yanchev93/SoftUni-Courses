function solve(n, k) {
    let firstElement = 1;

    let arr = [1];

    for (let i = 1; i < n; i++) {
        let startIndex = Math.max(0, i - k);

        let currentElement = arr
                            .slice(startIndex, startIndex + k)
                            .reduce((acc, curr) => acc + curr, 0);

        arr.push(currentElement);
    }

    return arr.join(' ');
}

console.log(solve(6, 3));
console.log(solve(8, 2));