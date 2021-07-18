function solve() {
    const stopName = document.querySelector('.info');
    const arriveBtn = document.querySelector('#arrive');
    const departBtn = document.querySelector('#depart');

    let currentStop = '';
    let url = 'http://localhost:3030/jsonstore/bus/schedule/depot';
    async function depart() {
        try {
            let responseDepart = await fetch(url);
            let dataDepart = await responseDepart.json();

            stopName.textContent = `Next stop ${dataDepart.name}`;
            url = 'http://localhost:3030/jsonstore/bus/schedule/' + dataDepart.next;
            arriveBtn.disabled = false;
            departBtn.disabled = true;
            currentStop = dataDepart.name;
        } catch (error) {
            stopName.textContent = `Error`;
        }

    }

    function arrive() {
        stopName.textContent = `Arriving at ${currentStop}`;

        arriveBtn.disabled = true;
        departBtn.disabled = false;
    }
    // stopName.textContent = `Error`;


    return {
        depart,
        arrive
    };
}

let result = solve();