function calculate(fruit, weight, money) {
    let weightInKg = weight / 1000;
    let moneyPerKg = weightInKg * money;

    console.log(`I need $${moneyPerKg.toFixed(2)} to buy ${weightInKg.toFixed(2)} kilograms ${fruit}.`);
}

calculate('orange', 2500, 1.80);
calculate('apple', 1563, 2.35);