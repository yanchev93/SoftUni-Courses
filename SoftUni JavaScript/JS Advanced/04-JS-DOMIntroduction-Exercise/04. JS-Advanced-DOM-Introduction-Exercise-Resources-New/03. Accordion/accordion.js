function toggle() {
    let button = document.querySelector('.button');
    let extraText = document.getElementById('extra');
    let styleDisplay = extraText.style.display;

    button.textContent = button.textContent != 'Less' ? 'Less' : 'More';
    extraText.style.display = styleDisplay != 'block' ? 'block' : 'none';
}