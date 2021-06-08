const assert = require('chai').assert;
const lookupChar = require('./03.CharLookup');

describe("Test lookupChar", () => {
    it("Check validation", () => {
        assert.isUndefined(lookupChar(1, 2));
    });

    it("Check validation", () => {
        assert.isUndefined(lookupChar('abc', 'a'));
    });

    it("Check validation", () => {
        assert.isUndefined(lookupChar('abc', 1.1));
    });

    it("Check validation", () => {
        assert.isUndefined(lookupChar(undefined, undefined));
    });

    it("Check incorect INDEX above string length", () => {
        assert.equal(lookupChar('123', 4), 'Incorrect index');
    });

    it("Check incorect INDEX below 0", () => {
        assert.equal(lookupChar('123', -100), 'Incorrect index');
    });

    it("It works", () => {
        assert.equal(lookupChar('123', 1), '2');
    });

    it("It works", () => {
        assert.equal(lookupChar('', 0), '');
    });
});