const testNumbers = {
    sumNumbers: function (num1, num2) {
        let sum = 0;

        if (typeof (num1) !== 'number' || typeof (num2) !== 'number') {
            return undefined;
        } else {
            sum = (num1 + num2).toFixed(2);
            return sum;
        }
    },
    numberChecker: function (input) {
        input = Number(input);

        if (isNaN(input)) {
            throw new Error('The input is not a number!');
        }

        if (input % 2 === 0) {
            return 'The number is even!';
        } else {
            return 'The number is odd!';
        }

    },
    averageSumArray: function (arr) {

        let arraySum = 0;

        for (let i = 0; i < arr.length; i++) {
            arraySum += arr[i];
        }

        return arraySum / arr.length;
    }
};

const assert = require('chai').assert;

describe("Tests", () => {
    it("sumNumber", () => {
        assert.isUndefined(testNumbers.sumNumbers("a", 1));
        assert.isUndefined(testNumbers.sumNumbers(1, "a"));

        assert.equal(testNumbers.sumNumbers(1, -1), 0, 00);
        assert.equal(testNumbers.sumNumbers(1.12, 1.1), 2.22);
        assert.equal(testNumbers.sumNumbers(-1.12, -1.1), -2.22);
    });

    it("numberCHecker", () => {
        assert.throws(() => testNumbers.numberChecker("a"), 'The input is not a number!');

        assert.equal(testNumbers.numberChecker("1"), 'The number is odd!');
        assert.equal(testNumbers.numberChecker("2"), 'The number is even!');
        assert.equal(testNumbers.numberChecker(2), 'The number is even!');
        assert.equal(testNumbers.numberChecker(1), 'The number is odd!');

    });

    it("averageSumArray", () => {
        const arr = [2, 2];

        assert.equal(testNumbers.averageSumArray(arr), 2);
    });
});

