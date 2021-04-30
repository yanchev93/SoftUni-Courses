function solve(input) {
    let output = input
        .split(/[' .,!?-]/g)
        .filter(x => x != '')
        .map(x => x.toUpperCase())
        .join(', ');

    console.log(output);
}

solve('Hi, how are you?');
solve('hello');