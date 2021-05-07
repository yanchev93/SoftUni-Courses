function calc() {
    let firstNum = document.getElementById('num1').value;
    let secondNum = document.getElementById('num2').value;

    let result = Number(firstNum) + Number(secondNum);


    if (!Number.isInteger(result)) {
        document.getElementById('sum').value = '';
    } else {
        document.getElementById('sum').value = result;
    }
}
