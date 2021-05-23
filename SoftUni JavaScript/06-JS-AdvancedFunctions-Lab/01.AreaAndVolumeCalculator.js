function area() {
    return Math.abs(this.x * this.y);
}

function volume() {
    return Math.abs(this.x * this.y * this.z);
}

function solve(area, volume, input) {
    let jsonObj = JSON.parse(input);


    let outputArr = [];
    for (const line of jsonObj) {
        const output = {
            area: area.call(line),
            volume: volume.call(line)
        };

        outputArr.push(output);
    }

    return outputArr;
}

console.log(solve(area, volume,
    `[{ "x": "1", "y": "2", "z": "10" },
    { "x": "7", "y": "7", "z": "10" },
    { "x": "5", "y": "2", "z": "10" }]`
));