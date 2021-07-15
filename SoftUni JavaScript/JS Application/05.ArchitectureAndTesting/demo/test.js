const { chromium } = require('playwright-chromium');
const { expect } = require('chai');

let browser, page; // Declare reusable variables

describe('E2E test', function () {
    this.timeout(6000);

    before(async () => { browser = await chromium.launch(); });

    after(async () => { await browser.close(); });

    beforeEach(async () => { page = await browser.newPage(); });

    afterEach(async () => { await page.close(); });

    it('load static', async () => {
        await page.goto('https://www.wikipedia.org');
        await page.screenshot({ path: 'index.png' });
    });
});