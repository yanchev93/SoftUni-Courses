function carFactory(car) {
    let engines = [
        { power: 90, volume: 1800 },
        { power: 120, volume: 2400 },
        { power: 200, volume: 3500 }
    ];

    let wantedEngine = engines.find(e => e.power >= car.power);

    let wantedCarriege = car.carriage == 'hatchback'
        ? { type: 'hatchback', color: car.color }
        : { type: 'coupe', color: car.color };

    let wheel = Math.floor(car.wheelsize) % 2 != 0
        ? Math.floor(car.wheelsize)
        : Math.floor(car.wheelsize) - 1;

    let wantedWheels = [wheel, wheel, wheel, wheel]

    let objCar = {
        model: car.model,
        engine: wantedEngine,
        carriage: wantedCarriege,
        wheels: wantedWheels
    };

    return objCar;
}

console.log(carFactory(
    {
        model: 'VW Golf II',
        power: 90,
        color: 'blue',
        carriage: 'hatchback',
        wheelsize: 14
    }
));

console.log('');

console.log(carFactory(
    {
        model: 'Opel Vectra',
        power: 110,
        color: 'grey',
        carriage: 'coupe',
        wheelsize: 17
    }
));