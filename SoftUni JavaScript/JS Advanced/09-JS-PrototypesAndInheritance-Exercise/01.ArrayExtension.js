Array.prototype.last = function () {
    return this[this.length - 1];
}

Array.prototype.skip = function (n) {
    if (n < 0 || this.length <= n) {
        return new Error('"N" cannot be negative or outside the bonds of the array');
    }

    let result = [];
    for (let i = n; i < this.length; i++) {
        result.push(this[i]);
    }

    return result;
}

Array.prototype.take = function (n) {
    if (n < 0 || this.length <= n) {
        return new Error('"N" cannot be negative or outside the bonds of the array');
    }

    let result = [];
    for (let i = 0; i < n; i++) {
        result.push(this[i]);
    }

    return result;
}

Array.prototype.sum = function () {
    return this.reduce((acc, curr) => { return acc + curr; }, 0);
}

Array.prototype.average = function () {
    return this.sum() / this.length;
}

(function solve() {
    Array.prototype.last = function () { };
    Array.prototype.skip = function () { };
    Array.prototype.take = function () { };
    Array.prototype.sum = function () { };
    Array.prototype.average = function () { };
})()