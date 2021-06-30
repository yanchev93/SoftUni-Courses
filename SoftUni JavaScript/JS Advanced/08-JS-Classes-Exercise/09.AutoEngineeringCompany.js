function produceCars(input) {
    let brands = {};

    let data = input;
    while (0 < data.length) {
        const arr = data.shift().split(' | ');
        const carBrand = arr[0];
        const carModel = arr[1];
        const producedCars = Number(arr[2]);

        if (!brands[carBrand]) {
            brands[carBrand] = {};
        }

        if (!brands[carBrand][carModel]) {
            let firstProduction = 0;
            brands[carBrand][carModel] = firstProduction;
        };
        brands[carBrand][carModel] += producedCars;
    }

    let output = [];
    for (const [brand, carModel] of Object.entries(brands)) {
        output.push(brand);
        for (const [key, value] of Object.entries(carModel)) {
            output.push(`###${key} -> ${value}`);
        }
    }

    return output.join('\n');
}

console.log(produceCars(['Audi | Q7 | 1000',
    'Audi | Q6 | 100',
    'BMW | X5 | 1000',
    'BMW | X6 | 100',
    'Citroen | C4 | 123',
    'Volga | GAZ-24 | 1000000',
    'Lada | Niva | 1000000',
    'Lada | Jigula | 1000000',
    'Citroen | C4 | 22',
    'Citroen | C5 | 10']
));