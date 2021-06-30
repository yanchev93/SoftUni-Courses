function lockedProfile() {
    const buttons = Array.from(document.querySelectorAll('button'));
    buttons.forEach(b => b.addEventListener('click', onClick));

    function onClick(event) {
        let profile = event.target.parentNode;
        let hiddenInfo = profile.querySelector('div');
        let isLocked = profile.querySelector('input[type=radio]:checked').value == 'lock';

        if (isLocked) {
            return;
        }

        isShown = hiddenInfo.style.display == 'block';
        hiddenInfo.style.display = isShown ? 'none' : 'block';

        textBtn = event.target.textContent == 'Show more';
        event.target.textContent = textBtn ? 'Hide it' : 'Show more';
    }
}