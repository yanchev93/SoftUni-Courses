import page from 'page/page';

import { dashboardPage } from './views/dashboard.js';
import { myFurniturePage } from './views/myFurnitures.js';
import { detailsPage } from './views/details.js';
import { createPage } from './views/create.js';
import { editPage } from './views/edit.js';
import { loginPage } from './views/login.js';
import { registerPage } from './views/register.js';

import * as api from './api/api.js';

api.settings.host = 'http://localhost:3030';

window.api = api;

page('/', dashboardPage);
page('/my-furniture', myFurniturePage);
page('/details/:id', detailsPage);
page('/create', createPage);
page('/edit/:id', editPage);
page('/register', registerPage);
page('login', loginPage);

page.start();