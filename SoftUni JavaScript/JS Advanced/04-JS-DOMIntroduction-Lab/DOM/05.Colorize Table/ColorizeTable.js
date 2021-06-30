function colorize() {
    let evenRows = document.getElementsByTagName('tr');

    for (i = 1; i < evenRows.length; i += 2) {
        evenRows[i].style.backgroundColor = 'teal';
    }
}