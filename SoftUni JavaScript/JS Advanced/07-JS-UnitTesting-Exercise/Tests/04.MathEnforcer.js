let mathEnforcer = {
    addFive: function (num) {
        if (typeof(num) !== 'number') {
            return undefined;
        }
        return num + 5;
    },
    subtractTen: function (num) {
        if (typeof(num) !== 'number') {
            return undefined;
        }
        return num - 10;
    },
    sum: function (num1, num2) {
        if (typeof(num1) !== 'number' || typeof(num2) !== 'number') {
            return undefined;
        }
        return num1 + num2;
    }
};

const assert = require('chai').assert;

describe('Test mathEnforcer', () => {
    it('addFive', () => {
        assert.equal(mathEnforcer.addFive(1.1), 6.1);
        assert.equal(mathEnforcer.addFive(1), 6);
        assert.equal(mathEnforcer.addFive(-1), 4);
        assert.equal(mathEnforcer.addFive(-1.5), 3.5);
        assert.equal(mathEnforcer.addFive(-6), -1);
        assert.equal(mathEnforcer.addFive(-6.2), -1.2000000000000002);
        assert.isUndefined(mathEnforcer.addFive('a'));
    });

    it('subtractTen', () => {
        assert.equal(mathEnforcer.subtractTen(5), -5);
        assert.equal(mathEnforcer.subtractTen(-5), -15);
        assert.equal(mathEnforcer.subtractTen(5.5), -4.5);
        assert.equal(mathEnforcer.subtractTen(-5.5), -15.5);
        assert.equal(mathEnforcer.subtractTen(10), 0);
        assert.equal(mathEnforcer.subtractTen(15), 5);
        assert.isUndefined(mathEnforcer.subtractTen('a'));
    });

    it('sum', () => {
        assert.equal(mathEnforcer.sum(2, 2), 4);
        assert.equal(mathEnforcer.sum(2.2, 2.2), 4.4);
        assert.equal(mathEnforcer.sum(-2.2, 2.2), 0);
        assert.equal(mathEnforcer.sum(-2.2,-2.2), -4.4);
        assert.equal(mathEnforcer.sum(2,-3), -1);
        assert.isUndefined(mathEnforcer.sum('a', 1));
        assert.isUndefined(mathEnforcer.sum(1, 'a'));
    });
});