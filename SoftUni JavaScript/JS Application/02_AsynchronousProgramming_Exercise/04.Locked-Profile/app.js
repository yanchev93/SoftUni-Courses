async function lockedProfile() {
    const users = await getUsers();
    const main = document.getElementById('main');

    let count = 0;
    for (const user of Object.values(users)) {
        count += 1;
        const age = user.age;
        const email = user.email;
        const username = user.username;
        const profile = e('div', { className: 'profile' },
            e('img', { src: `./iconProfile2.png`, className: 'userIcon' }),
            e('label', {}, 'Lock'),
            e('input', { type: 'radio', name: `user${count}Locked`, value: 'lock' }),
            e('label', {}, 'Unlock'),
            e('input', { type: 'radio', name: `user${count}Locked`, value: 'unlock' }),
            e('br'),
            e('hr'),
            e('label', {}, 'Username'),
            e('input', { type: 'text', name: `user${count}Username`, value: `${username}` }),
            e('div', { id: `user${count}HiddenFields` },
                e('hr'),
                e('label', {}, 'Email:'),
                e('input', { type: 'email', name: `user${count}Email`, value: `${email}` }),
                e('label', {}, 'Age:'),
                e('input', { type: 'email', name: `user${count}Age`, value: `${age}` })
            ),
            e('button', {}, 'Show more')
        );

        const hiddenDiv = profile.children[9];
        const usernameDiv = profile.children[8];
        const checkedDiv = profile.children[2];
        const button = profile.lastChild;

        checkedDiv.checked = true;
        usernameDiv.value = username;
        usernameDiv.disabled = true;
        usernameDiv.readOnly = true;
        hiddenDiv.children[2].disabled = true;
        hiddenDiv.children[2].readOnly = true;
        hiddenDiv.children[4].disabled = true;
        hiddenDiv.children[4].readOnly = true;
        hiddenDiv.style.display = 'none';
        main.appendChild(profile);

        button.addEventListener('click', () => {
            if (profile.children[4].checked == false) {
                return;
            }

            if (hiddenDiv.style.display == 'none') {
                hiddenDiv.style.display = 'block';
                button.textContent = 'Show less';
            } else {
                hiddenDiv.style.display = 'none';
                button.textContent = 'Show more';

            }
        });
    }


}

async function getUsers() {
    const url = 'http://localhost:3030/jsonstore/advanced/profiles';

    const response = await fetch(url);
    const data = await response.json();

    return data;
}

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