function lowestPrices(input) {
    let result = {};

    while (input.length) {
        let [town, product, price] = input.shift().split(' | ');
        price = Number(price);

        if (!result[product]) {
            
            result[product] = { town, price };
        } else {
            result[product] = result[product].price > price ? { town, price } : result[product];
        }
    }

    let output = [];

    for (const product in result) {
        output.push(`${product} -> ${result[product].price} (${result[product].town})`);
    }

    return output.join('\n')
}

console.log(lowestPrices(
    ['Sofia City | Audi | 100000',
    'Sofia City | BMW | 100000',
    'Sofia City | Mitsubishi | 10000',
    'Sofia City | Mercedes | 10000',
    'Sofia City | NoOffenseToCarLovers | 0',
    'Mexico City | Audi | 1000',
    'Mexico City | BMW | 99999',
    'New York City | Mitsubishi | 10000',
    'New York City | Mitsubishi | 1000',
    'Mexico City | Audi | 100000',
    'Washington City | Mercedes | 1000']
));

console.log(lowestPrices(
    ['Sample Town | Sample Product | 1000',
        'Sample Town | Orange | 2',
        'Sample Town | Peach | 1',
        'Sofia | Orange | 3',
        'Sofia | Peach | 2',
        'New York | Sample Product | 1000.1',
        'New York | Burger | 10']

));