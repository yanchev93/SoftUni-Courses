const numberOperations = require('./03.NumberOperations.js');
const assert = require('chai').assert;

describe('Tests', () => {
    it('powNumber', () => {
        assert.equal(numberOperations.powNumber(2), 4);

        assert.isNaN(numberOperations.powNumber('a'));
    });

    it('numberChecker', () => {
        assert.isNaN(numberOperations.numberChecker('a'));
    });
});