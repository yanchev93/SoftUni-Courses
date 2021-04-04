function solve(numbers) {
    const sum = function (numbers) {
        let result = 0;

        for (let i = 0; i < numbers.length; i++) {
            result += Number(numbers[i]);
        }

        return result;
    };

    const sumInverts = function (numbers) {
        let result = 0;

        for (let i = 0; i < numbers.length; i++) {
            result += 1 / numbers[i];
        }

        return result;
    };

    const concat = function (numbers) {
        let concatedResult = '';

        for (let i = 0; i < numbers.length; i++) {
            concatedResult += numbers[i];
        }

        return concatedResult;
    };

    console.log(sum(numbers));
    console.log(sumInverts(numbers));
    console.log(concat(numbers));
}

solve(['1', '2', '3']);
solve([2, 4, 8, 16]);