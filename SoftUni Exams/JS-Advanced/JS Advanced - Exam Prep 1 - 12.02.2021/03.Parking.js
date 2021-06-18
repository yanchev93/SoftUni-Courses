let pizzUni = {
    makeAnOrder: function (obj) {

        if (!obj.orderedPizza) {
            throw new Error('You must order at least 1 Pizza to finish the order.');
        } else {
            let result = `You just ordered ${obj.orderedPizza}`;
            if (obj.orderedDrink) {
                result += ` and ${obj.orderedDrink}.`;
            }
            return result;
        }
    },

    getRemainingWork: function (statusArr) {

        const remainingArr = statusArr.filter(s => s.status != 'ready');

        if (remainingArr.length > 0) {

            let pizzaNames = remainingArr.map(p => p.pizzaName).join(', ');
            let pizzasLeft = `The following pizzas are still preparing: ${pizzaNames}.`;

            return pizzasLeft;
        } else {
            return 'All orders are complete!';
        }

    },

    orderType: function (totalSum, typeOfOrder) {
        if (typeOfOrder === 'Carry Out') {
            totalSum -= totalSum * 0.1;

            return totalSum;
        } else if (typeOfOrder === 'Delivery') {

            return totalSum;
        }
    }
};

const assert = require('chai').assert;

describe('Tests', () => {
    it('makeAnOrder', () => {
        const noOrder = {};

        const orderPizza = { orderedPizza: 'pizza' };

        const orderPizzaAndDrink = { orderedPizza: 'pizza', orderedDrink: 'drink' };

        assert.throw(() => pizzUni.makeAnOrder(noOrder), 'You must order at least 1 Pizza to finish the order.');

        assert.equal(pizzUni.makeAnOrder(orderPizza), `You just ordered pizza`);

        assert.equal(pizzUni.makeAnOrder(orderPizzaAndDrink), `You just ordered pizza and drink.`);
    });

    it('getRemainingWork', () => {
        const notReady = [{ pizzaName: 'pizzaMizza', status: 'notReady' }];
        const ready = [{ pizzaName: 'pizza', status: 'ready' }];

        assert.equal(pizzUni.getRemainingWork(notReady), `The following pizzas are still preparing: pizzaMizza.`);
        assert.equal(pizzUni.getRemainingWork(ready), 'All orders are complete!');
    });

    it('orderType', () => {
        const totalSum = 10;

        assert.equal(pizzUni.orderType(totalSum, 'Delivery'), 10);
        assert.equal(pizzUni.orderType(totalSum, 'Carry Out'), 9);
    });
});