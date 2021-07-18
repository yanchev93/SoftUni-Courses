
const { expect } = require('chai');
const exp = require('constants');
const { chromium } = require('playwright-chromium');

let browser, page; // Declare reusable variables
let clientUrl = 'http://127.0.0.1:5500/01.Messenger/';

function fakeResponse(data) {
    return {
        status: 200,
        headers: {
            'Access-Control-Allow-Origin': '*',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(data),
    };
}

let testMessages = {
    1: {
        author: 'Pesho',
        content: 'My message'
    },
    2: {
        author: 'Ivancho',
        content: 'Ivancho sent a message'
    }
};

let testCreateMessage = {
    3: {
        author: 'Stoyan',
        content: 'Stoyan message'
    },
};

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

    describe('Tests', () => {
        it('click refreshBtn & loadMessages', async () => {
            await page.route('**/jsonstore/messenger', route => {
                route.fulfill(fakeResponse(testMessages));
            });

            await page.goto(clientUrl);

            const [response] = await Promise.all([
                page.waitForResponse('**/jsonstore/messenger'),
                page.click('#refresh'),
            ]);

            let textAreaText = await page.$eval('#messages', (textArea) => textArea.value);

            let text = Object.values(testMessages).map(x => `${x.author}: ${x.content}`).join('\n');
            expect(textAreaText).to.eql(text);
        });

        it('click sendBtn & create message', async () => {
            let requestData = undefined;
            await page.route('**/jsonstore/messenger', (route, request) => {
                if (request.method().toLowerCase() == 'post') {
                    requestData = request.postData();
                    route.fulfill(fakeResponse(testCreateMessage));
                }

            });

            let expected = {
                author: 'Stoyan',
                content: 'Stoyan message'
            };
            await page.goto(clientUrl);

            await page.fill('#author', expected.author);
            await page.fill('#content', expected.content);

            const [response] = await Promise.all([
                page.waitForResponse('**/jsonstore/messenger'),
                page.click('#submit'),
            ]);

            let authorInput = await page.$eval('#author', a => a.value);
            let contentInput = await page.$eval('#content', c => c.value);

            expect(authorInput).to.equal('');
            expect(contentInput).to.equal('');
        });
    });
});