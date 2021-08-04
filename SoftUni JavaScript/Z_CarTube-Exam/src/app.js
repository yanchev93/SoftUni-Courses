import page from '../node_modules/page/page.mjs';
import { render } from '../node_modules/lit-html/lit-html.js';

import { logout as apiLogout } from './api/data.js';
import { loginPage } from './views/loginView.js';
import { registerPage } from './views/registerView.js';
import { homePage } from './views/homeView.js';
import { catalogPage } from './views/catalogView.js';
import { createPage } from './views/createView.js';
import { detailsPage } from './views/detailsView.js';
import { editPage } from './views/editView.js';
import { myListingsPage } from './views/myListingsView.js';

const main = document.querySelector('main');
setUserNav();
document.getElementById('logoutBtn').addEventListener('click', logout);

page('/', decorateContext, homePage);
page('/login', decorateContext, loginPage);
page('/register', decorateContext, registerPage);
page('/catalog', decorateContext, catalogPage);
page('/create', decorateContext, createPage);
page('/details/:id', decorateContext, detailsPage);
page('/edit/:id', decorateContext, editPage);
page('/myListings', decorateContext, myListingsPage);


page.start();

function decorateContext(ctx, next) {
    ctx.render = (content) => render(content, main);
    ctx.setUserNav = setUserNav;


    next();
}

function setUserNav() {
    const username = sessionStorage.getItem('username');
    if (username != null) {
        document.querySelector('div #profile > a').textContent = `${username}`;
        document.querySelector('#profile').style.display = '';
        document.querySelector('#guest').style.display = 'none';
    } else {
        document.querySelector('#guest').style.display = '';
        document.querySelector('#profile').style.display = 'none';
    }
}

async function logout() {
    await apiLogout();
    setUserNav();
    page.redirect('/');
}