function solve(args) {
    let result = [];
    let values = {};

    [...arguments].forEach(x => {
        result.push({ type: typeof x, value: x });

        if (!values[typeof x]) {
            values[typeof x] = 0;
        }

        values[typeof x] += 1;
    });

    result.forEach(x => console.log(`${x.type}: ${x.value}`));
    // sorted.forEach(x => x.sort((a, b) => a.value - b.value));
    let sort = Object.entries(values).sort((a, b) => b[1] - a[1]);

    sort.forEach(x => {
        console.log(`${x[0]} = ${x[1]}`);
    });
}

solve('cat', 'a', 42, function () { console.log('Hello world!'); });