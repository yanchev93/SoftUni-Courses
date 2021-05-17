function attachEventsListeners() {
    const daysBtn = document.querySelector('#daysBtn');
    const hoursBtn = document.querySelector('#hoursBtn');
    const minutesBtn = document.querySelector('#minutesBtn');
    const secondsBtn = document.querySelector('#secondsBtn');

    daysBtn.addEventListener('click', onClickDays);
    hoursBtn.addEventListener('click', onClickHours);
    minutesBtn.addEventListener('click', onClickMinutes);
    secondsBtn.addEventListener('click', onClickSeconds);

    function onClickDays(event) {
        let inputfields = Array.from(event.target.parentNode.parentNode.querySelectorAll('div'));

        let dayInput = Number(inputfields[0].querySelector('#days').value);

        let hourInput = inputfields[1].querySelector('#hours');
        let minuteInput = inputfields[2].querySelector('#minutes');
        let secondInput = inputfields[3].querySelector('#seconds');

        const hours = dayInput * 24;
        const minutes = dayInput * 1440;
        const seconds = dayInput * 86400;

        hourInput.value = hours;
        minuteInput.value = minutes;
        secondInput.value = seconds;
    }

    function onClickHours(event) {
        let inputfields = Array.from(event.target.parentNode.parentNode.querySelectorAll('div'));

        let hourInput = Number(inputfields[1].querySelector('#hours').value);

        let dayInput = inputfields[0].querySelector('#days');
        let minuteInput = inputfields[2].querySelector('#minutes');
        let secondInput = inputfields[3].querySelector('#seconds');

        const days = hourInput / 24;
        const minutes = hourInput * 60;
        const seconds = hourInput * 3600;

        dayInput.value = days;
        minuteInput.value = minutes;
        secondInput.value = seconds;
    }

    function onClickMinutes(event) {
        let inputfields = Array.from(event.target.parentNode.parentNode.querySelectorAll('div'));

        let minuteInput = Number(inputfields[2].querySelector('#minutes').value);

        let dayInput = inputfields[0].querySelector('#days');
        let hourInput = inputfields[1].querySelector('#hours');
        let secondInput = inputfields[3].querySelector('#seconds');

        const days = minuteInput / 1440;
        const hours = minuteInput / 60;
        const seconds = minuteInput * 60;

        dayInput.value = days;
        hourInput.value = hours;
        secondInput.value = seconds;
    }

    function onClickSeconds(event) {
        let inputfields = Array.from(event.target.parentNode.parentNode.querySelectorAll('div'));

        let secondInput = Number(inputfields[3].querySelector('#seconds').value);

        let dayInput = inputfields[0].querySelector('#days');
        let hourInput = inputfields[1].querySelector('#hours');
        let minuteInput = inputfields[2].querySelector('#minutes');

        const days = secondInput / 86400;
        const hours = secondInput / 3600;
        const minutes = secondInput / 60;

        dayInput.value = days;
        hourInput.value = hours;
        minuteInput.value = minutes;
    }
}