function solve(num = 5) {
    let output = '';

    for (let i = 0; i < num; i++) {
        for (let j = 0; j < num; j++) {
            output += '*' + ' ';
        }
        
        output += '\n';
    }

    console.log(output.trim());
}
