function solve() {
    const addBtn = document.querySelector('button');

    const lectureName = document.querySelector('input[name="lecture-name"]');
    const lectureDate = document.getElementsByName('lecture-date')[0];
    const lectureModule = document.getElementsByTagName('select')[0];

    let trainings = document.querySelector('.modules');

    addBtn.addEventListener('click', (e) => {
        e.preventDefault();

        if (lectureName.value == '' || lectureDate.value == '' || lectureModule.value == 'Select module') {
            return;
        }

        let addTitle = createEl('h3', lectureModule.value);
        addTitle.textContent = addTitle.textContent.toUpperCase() + '-MODULE';
        let ulElement = document.createElement('ul');
        let liElement = document.createElement('li');
        let outputElement = document.createElement('h4');
        let btnElement = createEl('button', 'Del', 'red');

        const currentModules = document.querySelectorAll('.modules>h3');
        let allModules = [];
        if (currentModules.length > 0) {
            currentModules.forEach(x => allModules.push(x.textContent));
        }

        if (allModules.includes(addTitle.textContent)) {
            console.log('HUI');
        }


        trainings.appendChild(addTitle);


        let date = lectureDate.value;
        let result = [];
        for (let i = 0; i < date.length; i++) {
            let letter = date[i];
            if (letter == '-') {
                letter = '/';
            } else if (letter == 'T') {
                letter = ' - ';
            }

            result.push(letter);
        }

        const output = lectureName.value + ' - ' + result.join('');
        outputElement.textContent = output;
        liElement.className = 'flex';
        liElement.appendChild(outputElement);
        liElement.appendChild(btnElement);
        ulElement.appendChild(liElement);
        trainings.appendChild(ulElement);



    });

    function createEl(type, content, className) {
        const result = document.createElement(type);
        result.textContent = content;
        if (className) {
            result.className = className;
        }
        return result;
    }

};