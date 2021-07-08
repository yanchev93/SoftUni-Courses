document.querySelector('form').addEventListener('submit', onLogin);

async function onLogin(ev) {
    ev.preventDefault();
    const formData = new FormData(ev.target);

    const email = formData.get('email');
    const password = formData.get('password');

    if (email == '' || password == '') {
        return alert('All field are required!');
    } 

    const url = 'http://localhost:3030/users/login';

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