function population(data) {
    let myObj = [];

    for (let i = 0; i < data.length; i++) {
        let input = data[i].split(' <-> ');

        let town = input[0];
        let population = input[1];

        if (!myObj.hasOwnProperty(town)) {
            myObj[town] = Number(population);
        } else {
            myObj[town] += Number(population);
        }
    }

    let output = [];

    for (const key in myObj) {
        output.push(`${key} : ${myObj[key]}`)
    }

    return output.join('\n')
}

console.log((population(['Istanbul <-> 100000',
    'Honk Kong <-> 2100004',
    'Jerusalem <-> 2352344',
    'Mexico City <-> 23401925',
    'Istanbul <-> 1000']
)));

console.log(population(['Sofia <-> 1200000',
    'Montana <-> 20000',
    'New York <-> 10000000',
    'Washington <-> 2345000',
    'Las Vegas <-> 1000000']
));
