class Restaurant {
    constructor(budgetMoney) {
        this.budgetMoney = budgetMoney;
        this.menu = {};
        this.stockProducts = {};
        this.history = [];
    }
    loadProducts(products) {
        products.forEach(x => {
            let product = x.split(' ');
            let productName = product[0];
            let productQuantity = Number(product[1]);
            let productTotalPrice = Number(product[2]);

            if (productTotalPrice <= this.budgetMoney) {
                if (this.stockProducts[productName] == undefined) {
                    this.stockProducts[productName] = productQuantity;
                    this.budgetMoney -= productTotalPrice;

                    this.history.push(`Successfully loaded ${productQuantity} ${productName}`);

                } else {
                    this.stockProducts[productName] += productQuantity;
                    this.budgetMoney -= productTotalPrice;

                    this.history.push(`Successfully loaded ${productQuantity} ${productName}`);

                }
            }
            else {
                this.history.push(`There was not enough money to load ${productQuantity} ${productName}`);
            }
        });

        return this.history.join('\n');
    }

    addToMenu(meal, products, price) {
        const currPrice = Number(price);
        let objProducts = {};
        products.forEach(x => {
            let product = x.split(' ');
            const name = product[0];
            let prodQty = Number(product[1]);

            objProducts[name] = prodQty;
        });
        if (this.menu[meal] == undefined) {
            this.menu[meal] = {
                objProducts,
                currPrice
            };

            if (Object.keys(this.menu).length == 1) {
                return `Great idea! Now with the ${meal} we have 1 meal in the menu, other ideas?`;
            } else {
                return `Great idea! Now with the ${meal} we have ${Object.keys(this.menu).length} meals in the menu, other ideas?`;
            }

        } else {
            return `The ${meal} is already in the our menu, try something different.`;
        }
    }

    showTheMenu() {
        if (Object.keys(this.menu).length == 0) {
            return `Our menu is not ready yet, please come later...`;
        }

        let output = [];
        for (const meal of Object.keys(this.menu)) {
            output.push(`${meal} - $ ${this.menu[meal].price}`);
        }

        return output.join('\n');
    }

    makeTheOrder(meal) {
        const order = this.menu[meal];

        if (order == undefined) {
            return `There is not {meal} yet in our menu, do you want to order something else?`;
        }

        for (const product of Object.keys(order.objProducts)) {
            if (!this.stockProducts.hasOwnProperty(product) || this.stockProducts[product] < order.objProducts[product]) {
                return `For the time being, we cannot complete your order (${meal}), we are very sorry...`;
            }
        }

        for (const product of Object.keys(order.objProducts)) {
            this.stockProducts[product] -= order.objProducts[product];
        }

        this.budgetMoney += order.currPrice;

        return `Your order (${meal}) will be completed in the next 30 minutes and will cost you ${order.currPrice}.`;
    }

}

// let kitchen = new Restaurant(1000);
// console.log(kitchen.loadProducts(['Banana 10 5', 'Banana 20 10', 'Strawberries 50 30', 'Yogurt 10 10', 'Yogurt 500 1500', 'Honey 5 50']));
// console.log(kitchen.addToMenu('frozenYogurt', ['Yogurt 1', 'Honey 1', 'Banana 1', 'Strawberries 10'], 9.99));
// console.log(kitchen.addToMenu('Pizza', ['Flour 0.5', 'Oil 0.2', 'Yeast 0.5', 'Salt 0.1', 'Sugar 0.1', 'Tomato sauce 0.5', 'Pepperoni 1', 'Cheese 1.5'], 15.55));

// console.log(kitchen.showTheMenu());

let kitchen = new Restaurant(1000);
kitchen.loadProducts(['Yogurt 30 3', 'Honey 50 4', 'Strawberries 20 10', 'Banana 5 1']);
kitchen.addToMenu('frozenYogurt', ['Yogurt 1', 'Honey 1', 'Banana 1', 'Strawberries 10'], 9.99);
console.log(kitchen.makeTheOrder('frozenYogurt'));
