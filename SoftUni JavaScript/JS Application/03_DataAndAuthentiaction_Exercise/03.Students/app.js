async function showStudents() {
    document.getElementById('form').addEventListener('submit', async (ev) => {
        ev.preventDefault();
        const formData = new FormData(ev.target);

        const firstName = formData.get('firstName');
        const lastName = formData.get('lastName');
        const facNum = formData.get('facultyNumber');
        const grade = formData.get('grade');

        if (firstName == '' || lastName == '' || facNum == '' || grade == '') {
            return alert('All fields are required!');
        }

        submitStudent(firstName, lastName, facNum, grade);

        ev.target.reset();
    });

}

showStudents();

async function submitStudent(firstName, lastName, facultyNumber, grade) {
    const url = 'http://localhost:3030/jsonstore/collections/students';

    const student = { firstName, lastName, facultyNumber, grade };
    const response = await fetch(url, {
        method: 'post',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(student)
    });

    if (response.ok == false) {
        const err = await response.json();
        alert(err.message);
    }

    postStudents();

}

async function postStudents() {
    const url = 'http://localhost:3030/jsonstore/collections/students';

    const response = await fetch(url);
    const data = await response.json();

    const tBody = document.querySelector('tbody');

    let output = [];
    Object.values(data).forEach(student => {
        const result =
        `<tr>
            <th>${student.firstName}</th>
            <th>${student.lastName}</th>
            <th>${student.facultyNumber}</th>
            <th>${student.grade}</th>
        </tr>`;

        output.push(result);
    });

    output.forEach(x => tBody.innerHTML += x);
}