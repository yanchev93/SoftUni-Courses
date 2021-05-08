function record(name, population, treasury) {
    let obj = {};

    obj.name = name;
    obj.population = population;
    obj.treasury = treasury;

    return obj;
}


console.log(record('Tortuga',
    7000,
    15000
));

console.log('');

console.log(record());