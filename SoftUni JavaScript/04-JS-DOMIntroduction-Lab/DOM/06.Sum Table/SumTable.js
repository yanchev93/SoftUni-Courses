function sumTable() {
    const rows = document.querySelectorAll('table tr');

    let result = 0;

    for (let i = 1; i < rows.length - 1; i++) {
        let col = rows[i].children;

        result += Number(col[col.length - 1].textContent);
    }

    document.getElementById('sum').textContent = result;
}