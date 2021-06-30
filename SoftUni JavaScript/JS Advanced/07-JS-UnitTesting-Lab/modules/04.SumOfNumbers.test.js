const sum = require('./04.SumOfNumbers');
const assert = require('chai').assert;

describe('Sum Func', () => {
    it('Test Array', () => {
        assert.equal(Array.isArray([1,2,3]), true);
    });

    it('Test is it Equal', () =>{
        assert.equal(sum([2,3,5]), 10);
    })
});