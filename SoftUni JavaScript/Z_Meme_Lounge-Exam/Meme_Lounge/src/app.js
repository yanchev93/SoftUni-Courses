import page from '../node_modules/page/page.mjs';
import { render } from '../node_modules/lit-html/lit-html.js';

import { logout as apiLogout } from './api/data.js';
import { homePage } from './views/home.js';
import { loginPage } from './views/login.js';
import { registerPage } from './views/register.js';
import { catalogPage } from './views/catalog.js';
import { createMemePage } from './views/create.js';
import { detailsPage } from './views/details.js';
import { editPage } from './views/edit.js';
import { profilePage } from './views/profile.js';
import { notify } from './notification.js';

const main = document.querySelector('main');
setUserNav();
document.getElementById('logoutBtn').addEventListener('click', logout);

page('/', decorateContext, homePage);
page('/login', decorateContext, loginPage);
page('/register', decorateContext, registerPage);
page('/catalog', decorateContext, catalogPage);
page('/create', decorateContext, createMemePage);
page('/details/:id', decorateContext, detailsPage);
page('/edit/:id', decorateContext, editPage);
page('/profile', decorateContext, profilePage);


page.start();

function decorateContext(ctx, next) {
    ctx.render = (content) => render(content, main);
    ctx.setUserNav = setUserNav;


    next();
}

function setUserNav() {
    const email = sessionStorage.getItem('email');
    if (email != null) {
        document.querySelector('div .profile > span').textContent = `Welcome, ${email}`;
        document.querySelector('.user').style.display = '';
        document.querySelector('.guest').style.display = 'none';
    } else {
        document.querySelector('.guest').style.display = '';
        document.querySelector('.user').style.display = 'none';
    }
}

async function logout() {
    await apiLogout();
    setUserNav();
    page.redirect('/');

}