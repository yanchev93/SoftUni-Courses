function validate() {
    document.querySelector('#email').addEventListener('change', onChange);

    function onChange(event) {
        const email = event.target.value;

        if (/[a-z]+\@[a-z]+\.[a-z]/.test(email)) {
            event.target.className = '';
        } else {
            event.target.className = 'error';
        }
    }
}