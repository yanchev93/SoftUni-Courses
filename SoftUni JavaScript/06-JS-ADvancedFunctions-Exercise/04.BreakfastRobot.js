function solution() {
    const ingredients = { carbohydrate: 0, flavour: 0, protein: 0, fat: 0 };

    const recipes = {
        apple: { carbohydrate: 1, flavour: 2 },
        lemonade: { carbohydrate: 10, flavour: 20 },
        burger: { carbohydrate: 5, fat: 7, flavour: 3 },
        eggs: { protein: 5, fat: 1, flavour: 1 },
        turkey: { protein: 10, carbohydrate: 10, fat: 10, flavour: 10 }
    };

    const commands = {
        restock: (microElement, qty) => {
            ingredients[microElement] += qty;

            return 'Success';
        },
        prepare: (item, qty) => {
            const product = Object.entries(recipes[item]);

            for (const [item, value] of product) {
                if (ingredients[item] < value * qty) {
                    return `Error: not enough ${item} in stock`;
                }
            }

            product.forEach(([item, countNeeded]) => {
                ingredients[item] -= countNeeded * qty;
            });

            return `Success`;
        },
        report: () => {
            Object.entries(ingredients)
                .map(([item, qty]) => `${item}=${qty}`)
                .join(' ');
        }
    };

    return function (cmnds) {
        let [currCmnd, item, count] = cmnds.split(' ');
        let qty = Number(count);

        return commands[currCmnd](item, qty);
    };
}

const manager = solution();
console.log(solution('restock carbohydrates 10 '));
console.log(solution('restock flavour 10'));
console.log(solution('prepare apple 1'));
console.log(solution('restock fat 10 '));
console.log(solution('prepare burger 1 '));
console.log(solution('report'));