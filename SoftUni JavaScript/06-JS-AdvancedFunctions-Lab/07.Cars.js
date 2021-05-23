function solve(input) {
    const objCommands = () => {
        const objCars = {};

        return {
            create: (name, inherite, parent) => {
                objCars[name] = inherite ? Object.create(objCars[parent]) : {};
            },
            set: (name, key, value) => { objCars[name][key] = value; },
            print: (name) => {
                let output = [];

                for (const key in objCars[name]) {
                    output.push(`${key}:${objCars[name][key]}`);
                }

                console.log(output.join(', '));
            }
        };
    };

    const createCar = objCommands();
    input.map(x => x.split(' '))
        .forEach(([command, ...args]) => createCar[command].apply(null, args));
}

solve(['create c1',
    'create c2 inherit c1',
    'set c1 color red',
    'set c2 model new',
    'print c1',
    'print c2']
);