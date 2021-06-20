function solve() {
    const addBtn = document.querySelector('button');
    const delBtn = document.querySelector('.red') == null ? undefined : document.querySelector('.red');

    const lectureName = document.querySelector('input[name="lecture-name"]');
    const lectureDate = document.getElementsByName('lecture-date')[0];
    const lectureModule = document.getElementsByTagName('select')[0];

    let trainings = document.querySelector('.modules');
    let objModules = {};

    addBtn.addEventListener('click', (e) => {
        e.preventDefault();

        if (lectureName.value == '' || lectureDate.value == '' || lectureModule.value == 'Select module') {
            return;
        }

        let liElement;
        let btnElement;
        let outputElement;
        let title;

        let name;
        let date;

        let ulElement = createEl('ul');

        let divH3 = Array.from(document.querySelectorAll('.module h3'));

        let addTitle = createEl('h3', lectureModule.value);
        addTitle.textContent = addTitle.textContent.toUpperCase() + '-MODULE';

        let doExist = divH3.filter(x => x.textContent == addTitle.textContent);
        if (doExist.length > 0) {
            const parentDiv = doExist[0].parentNode;
            title = addTitle.textContent;
            name = lectureName.value;
            date = lectureDate.value.split('-').join('/').split('T').join(' - ');

            objModules[title].push({ name, date });
            objModules[title].sort((a, b) => a.date.localeCompare(b.date));

            let liArr = [];
            for (const data of objModules[title]) {
                let [name, date] = Object.values(data);
                liElement = createEl('li', undefined, 'flex');
                btnElement = createEl('button', 'Del', 'red');
                outputElement = createEl('h4');

                outputElement.textContent = name + ' - ' + date;

                liElement.appendChild(outputElement);
                liElement.appendChild(btnElement);
                liArr.push(liElement);
            }

            parentDiv.removeChild(parentDiv.lastChild);
            liArr.forEach(x => ulElement.appendChild(x));
            parentDiv.appendChild(ulElement);

        } else {
            title = addTitle.textContent;
            name = lectureName.value;
            date = lectureDate.value.split('-').join('/').split('T').join(' - ');

            if (!objModules[title]) {
                objModules[title] = [];
            }

            objModules[title].push({ name, date });

            for (const data of objModules[title]) {
                let [name, date] = Object.values(data);
                liElement = createEl('li', undefined, 'flex');
                btnElement = createEl('button', 'Del', 'red');
                outputElement = createEl('h4');

                outputElement.textContent = name + ' - ' + date;

                liElement.appendChild(outputElement);
                liElement.appendChild(btnElement);
                ulElement.appendChild(liElement);

            }


            let divModule = createEl('div', undefined, 'module');
            divModule.appendChild(addTitle);
            divModule.appendChild(ulElement);
            trainings.appendChild(divModule);
        }
    });

    document.body.addEventListener('click', function (e) {
        if (e.target.className == 'red') {
            let parentLi = e.target.parentNode;

            const parentDiv = parentLi.parentNode.parentNode;
            const h3 = parentLi.parentNode.parentNode.children[0];

            let h4 = parentLi.querySelector('h4');
            let dataModule = parentLi.parentNode.parentNode.firstChild;
            let objData = Object.entries(objModules).find(x => x[0] == dataModule.textContent);
            let parentUl = Array.from(parentLi.parentNode.children);
            let deleteUl = parentLi.parentNode;

            let index;
            parentUl.forEach((x, i) => {
                if (x.firstChild.textContent == h4.textContent) {
                    index = i;
                }
            });

            objData[1].splice(index, 1);
            parentLi.remove();

            let lengthArr = parentUl.length - 1;

            if (lengthArr == 0) {
                deleteUl.remove();

                parentDiv.remove();
                delete objModules[objData[0]];
            }
        }
    });

    function createEl(type, content, className) {
        const result = document.createElement(type);
        if (content) {
            result.textContent = content;
        }

        if (className) {
            result.className = className;
        }

        return result;
    }

};