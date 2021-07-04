async function getRecipes() {
    const mainEl = document.querySelector('main');
    const url = `http://localhost:3030/jsonstore/cookbook/recipes`;

    try {
        const response = await fetch(url);

        if (response.ok == false) {
            throw new Error(response.statusText);
        }

        const data = await response.json();
        mainEl.innerHTML = '';
        Object.values(data).map(createPreview).forEach(r => mainEl.appendChild(r));

    } catch (err) {
        alert(err.message);
    }
}

function createPreview(data) {
    const result = e('article', { className: 'preview' },
        e('div', { className: 'title' }, e('h2', {}, data.name)),
        e('div', { className: 'small' }, e('img', { src: data.img }))
    );

    result.addEventListener('click', () => getDetails(data._id, result));

    return result;
}

async function getDetails(id, preview) {
    const urlDetails = `http://localhost:3030/jsonstore/cookbook/details/` + id;


    const responseDetails = await fetch(urlDetails);
    const dataDetails = await responseDetails.json();

    const result = e('article', {},
        e('h2', { onClick: toggleCard }, dataDetails.name),
        e('div', { className: 'band' },
            e('div', { className: 'thumb' }, e('img', { src: dataDetails.img })),
            e('div', { className: 'ingredients' },
                e('h3', {}, 'Ingredients:'),
                e('ul', {}, dataDetails.ingredients.map(i => e('li', {}, i)))
            )
        ),
        e('div', { className: 'description' },
            e('h3', {}, 'Preparation:'),
            dataDetails.steps.map(s => e('p', {}, s))
        )
    );

    preview.replaceWith(result);

    function toggleCard() {
        result.replaceWith(preview);
    }
}


window.addEventListener('load', () => {
    getRecipes();
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