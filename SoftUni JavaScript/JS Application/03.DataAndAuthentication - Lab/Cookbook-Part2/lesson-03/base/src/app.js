async function getRecipes() {
    const response = await fetch('http://localhost:3030/jsonstore/cookbook/recipes');
    const recipes = await response.json();

    return Object.values(recipes);
}

async function getRecipeById(id) {
    const response = await fetch('http://localhost:3030/jsonstore/cookbook/details/' + id);
    const recipe = await response.json();

    return recipe;
}

function createRecipePreview(recipe) {
    const result = e('article', { className: 'preview', onClick: toggleCard },
        e('div', { className: 'title' }, e('h2', {}, recipe.name)),
        e('div', { className: 'small' }, e('img', { src: recipe.img })),
    );

    return result;

    async function toggleCard() {
        const fullRecipe = await getRecipeById(recipe._id);

        result.replaceWith(createRecipeCard(fullRecipe));
    }
}

function createRecipeCard(recipe) {
    const result = e('article', {},
        e('h2', {}, recipe.name),
        e('div', { className: 'band' },
            e('div', { className: 'thumb' }, e('img', { src: recipe.img })),
            e('div', { className: 'ingredients' },
                e('h3', {}, 'Ingredients:'),
                e('ul', {}, recipe.ingredients.map(i => e('li', {}, i))),
            )
        ),
        e('div', { className: 'description' },
            e('h3', {}, 'Preparation:'),
            recipe.steps.map(s => e('p', {}, s))
        ),
    );

    return result;
}

window.addEventListener('load', async () => {
    const main = document.querySelector('main');

    const recipes = await getRecipes();
    const cards = recipes.map(createRecipePreview);

    main.innerHTML = '';
    cards.forEach(c => main.appendChild(c));
});

function e(type, attributes, ...content) {
    const result = document.createElement(type);

    for (let [attr, value] of Object.entries(attributes || {})) {
        if (attr.substring(0, 2) == 'on') {
            result.addEventListener(attr.substring(2).toLocaleLowerCase(), value);
        } else {
            result[attr] = value;
        }
    }

    content = content.reduce((a, c) => a.concat(Array.isArray(c) ? c : [c]), []);

    content.forEach(e => {
        if (typeof e == 'string' || typeof e == 'number') {
            const node = document.createTextNode(e);
            result.appendChild(node);
        } else {
            result.appendChild(e);
        }
    });

    return result;
}

async function readData() {
    const url = '';

    const response = await fetch(url);
    const data = await response.json();

    return data;
}

async function readDataById(id) {
    const url = '' + id;

    const response = await fetch(url);
    const data = await response.json();

    return data;
}

async function register(data) {
    const registerUrl = '';

    const response = await fetch(registerUrl, {
        method: 'post',
        headers: { 'Content-Type': 'application./json' },
        body: JSON.stringify(data)
    });

    if (response.ok) {
        const data = await response.json();
        sessionStorage.setItem('authToken', data.accessToken);
    } else {
        const error = await response.json();
        alert(error.message);
    }
}

async function login(email, password) {
    const loginUrl = '';

    const response = await fetch(loginUrl, {
        method: 'post',
        headers: { 'Content-Type': 'application./json' },
        body: JSON.stringify({ email, password })
    });

    if (response.ok) {
        const data = await response.json();
        sessionStorage.setItem('authToken', data.accessToken);
    } else {
        const error = await response.json();
        alert(error.message);
    }
}

async function getDataToken(token) {
    const url = '';

    const options = {
        method: 'get',
        headers: {}
    };

    const token = sessionStorage.getItem('authToken');

    if (token !== null) {
        options.headers['X-Authorization'] = token;
    }
    const response = await fetch(url, options);

    const data = await response.json();

    return data;
}
