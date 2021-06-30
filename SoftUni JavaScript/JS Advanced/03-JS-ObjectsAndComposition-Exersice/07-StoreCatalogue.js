function catalogue(input) {
    let products = {};

    while (input.length) {
        let [product, price] = input.shift().split(' : ');
        let char = product[0];
        price = Number(price);

        if (!products[char]) {
            products[char] = [];
        }

        products[char].push({ product, price });
    }

    products.sort((a,b) => a.localeCompare(b));

    console.log();

}

console.log(catalogue(
    ['Banana : 2',
        'Rubic\'s Cube : 5',
        'Raspberry P : 4999',
        'Rolex : 100000',
        'Rollon : 10',
        'Rali Car : 2000000',
        'Pesho : 0.000001',
        'Barrel : 10']

));