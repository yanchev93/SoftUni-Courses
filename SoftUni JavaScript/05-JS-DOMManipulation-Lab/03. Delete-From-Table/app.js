function deleteByEmail() {
    const input = document.querySelector('input');

    let trElements = document.querySelectorAll('tbody>tr');
    let tdArr = [];

    [...trElements].forEach(x => tdArr.push(x.getElementsByTagName('td')[1]));


    let deleteElement = undefined;

    tdArr.forEach(x => {
        if (x.textContent == input.value) {
            deleteElement = x;
        }
    });

    if (deleteElement == undefined) {
        document.querySelector('#result').textContent = 'Not found.';
    } else {
        deleteElement.parentNode.remove();

        document.querySelector('#result').textContent = 'Deleted';
    }

    input.value = '';
}