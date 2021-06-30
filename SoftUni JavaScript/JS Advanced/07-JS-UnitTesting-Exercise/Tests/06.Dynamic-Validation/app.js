function validate() {
    const input = document.querySelector('#email');
    const regex = /^\w+@\w+\.\w+$/gm;

    input.addEventListener('change', () => {
        if (!regex.test(input.value)) {
            input.classList.add('error');
        } else {
            input.removeAttribute('class');
        }
    });
}