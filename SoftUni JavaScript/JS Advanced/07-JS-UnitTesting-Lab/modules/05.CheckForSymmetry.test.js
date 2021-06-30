const isSymmetric = require('./05.CheckForSymmetry.js');
const assert = require('chai').assert;

describe('Tests', () => {
    it('Return FALSE not correct format', () => {
        assert.equal(isSymmetric(1), false);
    });

    it('Return FALSE not symetricc', () => {
        assert.equal(isSymmetric(['a', 'b']), false);
    });

    it('Return TRUE is symetric', () => {
        assert.equal(isSymmetric(['a', 'a']), true);
    });

    //overloading

    it('Return TRUE is symetric with odd input ', () => {
        assert.equal(isSymmetric([1, 1, 1]), true);
    });

    it('Return FALSE not symetric odd input', () => {
        assert.equal(isSymmetric([1, 2, 3]), false);
    });
});

