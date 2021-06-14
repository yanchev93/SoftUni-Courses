function createJuice(input) {
    let juiceBottles = {};
    let output = [];
    let firstInAppearance = [];
    input.map(x => x.split(' => '))
        .map(([product, qty]) => {
            if (!juiceBottles[product]) {
                juiceBottles[product] = 0;
            }

            juiceBottles[product] += Number(qty);

            if (1000 <= juiceBottles[product]) {
                if (!firstInAppearance.includes(product)) {
                    firstInAppearance.push(product);
                }
            }
        });

    const juiceObj = Object.entries(juiceBottles);
    for (let i = 0; i < firstInAppearance.length; i++) {
        const currJuice = juiceObj.find(x => x[0] == firstInAppearance[i]);
        const juiceName = currJuice[0];
        let qty = currJuice[1];

        let qtyBottles = 0;
        while (1000 <= qty) {
            qtyBottles += 1;

            qty -= 1000;
        }

        if (0 < qtyBottles) {
            output.push(`${juiceName} => ${qtyBottles}`);
        }
    }

    return output.join('\n');
}


console.log(createJuice(['Orange => 2000',
    'Peach => 1432',
    'Banana => 450',
    'Peach => 600',
    'Strawberry => 549']
));

console.log(createJuice(['Kiwi => 234',
    'Pear => 2345',
    'Watermelon => 3456',
    'Kiwi => 4567',
    'Pear => 5678',
    'Watermelon => 6789']
));