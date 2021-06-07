const isOddOrEven = require('./02.EvenOrOdd');
const assert = require('chai').assert;

describe("Tests", () => {
    it('even', () => {
        assert.equal(isOddOrEven('ab'), 'even');
    });
    it('odd', () => {
        assert.equal(isOddOrEven('a'), 'odd');
    });

    it('undefined', () => {
        assert.isUndefined(isOddOrEven(123));
    });
});