const { expect } = require('chai');
const { chromium } = require('playwright-chromium');

let browser, page; // Declare reusable variables

describe('E2E tests', function () {
    this.timeout(6000); //?
    before(async () => {
        // browser = await chromium.launch({ headless: false, slowMo: 500 }); // visualizing the actions
        browser = await chromium.launch();
    });

    after(async () => {
        await browser.close();
    });

    beforeEach(async () => {
        page = await browser.newPage();
    });

    afterEach(async () => {
        await page.close();
    });

    it('loads page', async () => {
        await page.goto('http://localhost:3000/');
        await page.screenshot({ path: 'index.png' });
    });
});