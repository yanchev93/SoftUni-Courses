async function attachEvents(ev) {

    document.querySelector('#submit').addEventListener('click', () => getWeather());
}

attachEvents();

async function getWeather() {
    const currentElement = document.querySelector('#current');
    const upcomingElement = document.querySelector('#upcoming');
    upcomingElement.style.display = 'block';

    currentElement.innerHTML = '';
    upcomingElement.innerHTML = '';

    const currentLabel = e('div', { className: 'label', innerHTML: 'Current conditions' });
    currentElement.appendChild(currentLabel);

    const upcomingLabel = e('div', { className: 'label', innerHTML: 'Three-day forecast' });
    upcomingElement.appendChild(upcomingLabel);

    const cityName = document.getElementById('location').value;
    document.querySelector("#forecast").style.display = 'block';

    const symbols = {
        'Sunny': '&#x2600;',
        'Partly sunny': '&#x26C5;',
        'Overcast': '&#x2601;',
        'Rain': '&#x2614;',
        'Degrees': '&#176;'

    };

    try {
        const code = await getCode(cityName);
        const [today, upcoming] = await Promise.all([
            todayData(code),
            upcomingData(code)
        ]);

        const divCurrent = e('div', { className: 'forecast' },
            e('span', { className: 'condition symbol', innerHTML: `${symbols[today.forecast.condition]}` }),
            e('span', { className: 'condition' },
                e('span', { className: 'forecast-data', innerHTML: `${today.name}` }),
                e('span', { className: 'forecast-data', innerHTML: `${today.forecast.high}${symbols.Degrees}/${today.forecast.low}${symbols.Degrees}` }),
                e('span', { className: 'forecast-data', innerHTML: `${today.forecast.condition}` })
            ),
        );

        currentElement.appendChild(divCurrent);

        const divUpForecast = e('div', { className: 'forecast-info' });
        upcoming.forecast.forEach(x => {
            let divUpcomming =
                e('span', { className: 'upcoming' },
                    e('span', { className: 'symbol', innerHTML: `${symbols[x.condition]}` }),
                    e('span', { className: 'forecast-data', innerHTML: `${x.high}${symbols.Degrees}/${x.low}${symbols.Degrees}` }),
                    e('span', { className: 'forecast-data', innerHTML: `${x.condition}` })
                );
            divUpForecast.appendChild(divUpcomming);
        });

        upcomingElement.appendChild(divUpForecast);
    } catch (err) {
        upcomingElement.style.display = 'none';
        currentElement.children[0].innerHTML = 'Error';
    }

}

async function getCode(cityName) {
    const url = 'http://localhost:3030/jsonstore/forecaster/locations';

    const response = await fetch(url);
    const data = await response.json();

    return data.find(x => x.name.toLowerCase() == cityName.toLowerCase()).code;
}

async function todayData(code) {
    const todayUrl = 'http://localhost:3030/jsonstore/forecaster/today/';

    const response = await fetch(todayUrl + code);
    const data = await response.json();

    return data;
}

async function upcomingData(code) {
    const upcomingUrl = 'http://localhost:3030/jsonstore/forecaster/upcoming/';

    const response = await fetch(upcomingUrl + code);
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
