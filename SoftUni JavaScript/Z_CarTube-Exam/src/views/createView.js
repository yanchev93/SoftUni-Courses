import { html } from '../../node_modules/lit-html/lit-html.js';

import { createCar } from '../api/data.js';

const createTemplate = (onSubmit) => html`
<section id="create-listing">
    <div class="container">
        <form @submit=${onSubmit} id="create-form">
            <h1>Create Car Listing</h1>
            <p>Please fill in this form to create an listing.</p>
            <hr>

            <p>Car Brand</p>
            <input type="text" placeholder="Enter Car Brand" name="brand">

            <p>Car Model</p>
            <input type="text" placeholder="Enter Car Model" name="model">

            <p>Description</p>
            <input type="text" placeholder="Enter Description" name="description">

            <p>Car Year</p>
            <input type="number" placeholder="Enter Car Year" name="year">

            <p>Car Image</p>
            <input type="text" placeholder="Enter Car Image" name="imageUrl">

            <p>Car Price</p>
            <input type="number" placeholder="Enter Car Price" name="price">

            <hr>
            <input type="submit" class="registerbtn" value="Create Listing">
        </form>
    </div>
</section>`;

export async function createPage(ctx) {
    ctx.render(createTemplate(onSubmit));

    async function onSubmit(event) {
        event.preventDefault();

        const fromData = new FormData(event.target);
        const brand = fromData.get('brand');
        const model = fromData.get('model');
        const description = fromData.get('description');
        let year = fromData.get('year');
        const imageUrl = fromData.get('imageUrl');
        let price = fromData.get('price');

        if (!brand || !model || !description || !year || !imageUrl || !price) {
            return alert('All fields are required!');
        }

        if (year < 0 || price < 0) {
            return alert('Year and Price must be positive numbers!');
        }

        year = Number(year);
        price = Number(price);

        await createCar({
            brand,
            model,
            description,
            year,
            imageUrl,
            price
        });

        ctx.page.redirect('/catalog');
    }
}