document.querySelector('form').addEventListener('submit', onCreate);

async function onCreate(ev) {
    ev.preventDefault();
    const token = sessionStorage.getItem('userToken');
    const formData = new FormData(ev.target);

    const name = formData.get('name');
    const img = formData.get('img');
    const ingredients = formData.get('ingredients').split('\n').map(l => l.trim()).filter(l => l != '');
    const steps = formData.get('steps').split('\n').map(l => l.trim()).filter(l => l != '');

    const url = 'http://localhost:3030/data/recipes?select=_id%2Cname%2Cimg';
    const response = await fetch(url, {
        method: 'post',
        headers: {
            'Content-Type': 'application/json',
            'X-Authorization': token
        },
        body: JSON.stringify({ name, img, ingredients, steps })
    });

    if (response.ok == false) {
        const error = await respnes.json();
        return alert(error.message);
    }

    window.location.pathname = 'index.html';
}