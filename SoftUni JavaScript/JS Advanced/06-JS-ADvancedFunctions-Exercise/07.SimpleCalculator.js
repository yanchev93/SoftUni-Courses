function solve() {
    let firstEl;
    let secondEl;
    let resultEl;

    return {
        init: (firstSelector, secondSelector, resultSelector) => {
            firstEl = document.querySelector(firstSelector);
            secondEl = document.querySelector(secondSelector);
            resultEl = document.querySelector(resultSelector);
        },
        add: () => {
            resultEl.value = Number(firstEl.value) + Number(secondEl.value);
        },
        subtract: () => {
            resultEl.value = Number(firstEl.value) - Number(secondEl.value);
        }
    };
}