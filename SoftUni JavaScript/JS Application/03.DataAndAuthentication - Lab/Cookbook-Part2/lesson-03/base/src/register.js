document.querySelector('form').addEventListener('submit', onRegisterSubmit);

async function onRegisterSubmit(ev) {
    ev.preventDefault();
    const formData = new FormData(ev.target);

    const email = formData.get('email');
    const password = formData.get('password');
    const repass = formData.get('rePass');

    if (email == '' || password == '') {
        return alert('All field are required!');
    } else if (password !== repass) {
        return alert('Passwords don\'t match!');
    }

    const url = 'http://localhost:3030/users/register';

    const response = await fetch(url, {
        method: 'post',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ email, password })
    });

    if (response.ok == false) {
        const error = await response.json();
        return alert(error.message);
    }

    const data = await response.json();
    sessionStorage.setItem('userToken', data.accessToken);
    window.location.pathname = 'index.html';
}