function focused() {
    const input = document.querySelectorAll('input');

    Array.from(input).forEach(i => {
        i.addEventListener('focus', onFocus);
        i.addEventListener('blur', onBlur)
    });

    function onFocus(event) {
        // console.log('focused');
        event.target.parentNode.className = 'focused';
    }

    function onBlur(event) {
        // console.log('blurred');
        event.target.parentNode.className = '';
    }

}