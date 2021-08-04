import { html } from '../../node_modules/lit-html/lit-html.js';

import { getMyMemes } from '../api/data.js';

const profileTemplate = (myMemes, username, email, userGender) => html`
<section id="user-profile-page" class="user-profile">
    <article class="user-info">
        <img id="user-avatar-url" alt="user-profile" src="/images/${userGender}.png">
        <div class="user-content">
            <p>Username: ${username}</p>
            <p>Email: ${email}</p>
            <p>My memes count: ${myMemes.length}</p>
        </div>
    </article>
    <h1 id="user-listings-title">User Memes</h1>
    <div class="user-meme-listings">
        ${myMemes.length == 0 
            ? html`<p class="no-memes">No memes in database.</p>` 
            : myMemes.map(memeTemplate)}
    </div>
</section>`;

const memeTemplate = (meme) => html`
<div class="user-meme">
    <p class="user-meme-title">${meme.title}</p>
    <img class="userProfileImage" alt="meme-img" src=${meme.imageUrl}>
    <a class="button" href="/details/${meme._id}">Details</a>
</div>`;

export async function profilePage(ctx){
    const myMemes = await getMyMemes();
    const username = sessionStorage.getItem('username');
    const email = sessionStorage.getItem('email');
    const userGender = sessionStorage.getItem('userGender');

    ctx.render(profileTemplate(myMemes,username,email,userGender));
}