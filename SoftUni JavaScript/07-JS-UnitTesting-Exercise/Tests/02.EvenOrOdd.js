function isOddOrEven(string) {
    if (typeof (string) !== 'string') {
        return undefined;
    }
    if (string.length % 2 === 0) {
        return "even";
    }

    return "odd";
}

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

module.exports = isOddOrEven;