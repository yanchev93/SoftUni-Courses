//const { use } = require("chai");
function validate() {
    const btn = document.querySelector('#submit');
    btn.type = 'button';

    const userName = document.querySelector('#username');
    const email = document.querySelector('#email');
    const password = document.querySelector('#password');
    const confirmPass = document.querySelector('#confirm-password');
    const companyCheck = document.querySelector('#company');
    const companyInfo = document.querySelector('#companyInfo');
    const validDiv = document.querySelector('#valid');
    
    companyCheck.addEventListener('change', (e) => {
        if (e.target.checked) {
            companyInfo.style.display = 'block';
        } else {
            companyInfo.style.display = 'none';
        }
    });
    
    let isValid = true;


    const regexUserName = /^[0-9a-zA-Z]{3,20}$/;
    const regexEmail = /^[^@.]+@[^@]*\.[^@]*$/;
    const regexPassword = /^\w{5,15}$/;

    btn.addEventListener('click', (e) => {
        if (regexUserName.exec(userName.value) === null) {
            userName.style.borderColor = 'red';
            isValid = false;
        } else {
            userName.style.border = '';
        }

        if (regexEmail.exec(email.value) === null) {
            email.style.borderColor = 'red';
            isValid = false;
        } else {
            email.style.borderColor = '';
        }

        if (password.value !== confirmPass.value ||
            regexPassword.exec(password.value) === null ||
            regexPassword.exec(confirmPass.value) === null) {
            password.style.borderColor = 'red';
            confirmPass.style.borderColor = 'red';

            isValid = false;
        } else {
            password.style.borderColor = '';
            confirmPass.style.borderColor = '';
        }

        if (companyCheck.checked) {
            let companyNumber = document.querySelector('#companyNumber');

            if (companyNumber.value < 1000 || 9999 < companyNumber.value) {
                companyNumber.style.borderColor = 'red';
                isValid = false;
            } else {
                companyNumber.style.borderColor = '';
            }
        }

        if (isValid) {
            validDiv.style.display = 'block';
        } else {
            validDiv.style.display = 'none';
        }

    });
}
