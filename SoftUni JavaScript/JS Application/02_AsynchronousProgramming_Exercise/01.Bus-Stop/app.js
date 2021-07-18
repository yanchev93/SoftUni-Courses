async function getInfo() {
    const stopId = document.getElementById('stopId');
    const stopName = document.getElementById('stopName');
    const stopBusses = document.getElementById('buses');
    const url = `http://localhost:3030/jsonstore/bus/businfo/` + stopId.value;

    try {
        stopBusses.innerHTML = '';

        const response = await fetch(url);
        const data = await response.json();
        stopName.textContent = data.name;

        console.log(data.buses);
        for (const bus of Object.keys(data.buses)) {
            const liElement = document.createElement('li');
            liElement.textContent = `Bus ${bus} arrives in ${data.buses[bus]} minutes`;

            stopBusses.appendChild(liElement);
        }

        stopId.value = '';
    } catch (err) {
        stopName.textContent = 'Error';
    }
}