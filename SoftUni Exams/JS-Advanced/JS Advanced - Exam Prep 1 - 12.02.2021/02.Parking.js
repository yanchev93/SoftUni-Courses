class Parking {
    constructor(capacity) {
        this.capacity = capacity;
        this.vehicles = [];
    }

    addCar(carModel, carNumber) {
        if (this.capacity == 0) {
            throw new Error('Not enough parking space.');
        }

        let car = {
            carModel,
            carNumber,
            payed: false
        };

        this.vehicles.push(car);
        this.capacity -= 1;

        return `The ${carModel}, with a registration number ${carNumber}, parked.`;
    }

    removeCar(carNumber) {
        const car = this.vehicles.findIndex(x => x.carNumber == carNumber);

        if (car == -1) {
            throw new Error(`The car, you're looking for, is not found.`);
        } else if (this.vehicles[car].payed == false) {
            throw new Error(`${carNumber} needs to pay before leaving the parking lot.`);
        }

        this.vehicles.splice(car, 1);

        return `${carNumber} left the parking lot.`;
    }

    pay(carNumber) {
        const car = this.vehicles.find(x => x.carNumber == carNumber);

        if (car == undefined) {
            throw new Error(`${carNumber} is not in the parking lot.`);
        } else if (car.payed) {
            throw new Error(`${carNumber}'s driver has already payed his ticket.`);
        }

        car.payed = true;
        return `${carNumber}'s driver successfully payed for his stay.`;
    }

    getStatistics(carNumber) {
        if (!carNumber) {
            let output = [];
            output.push(`The Parking Lot has ${this.capacity} empty spots left.`);

            this.vehicles.sort((a, b) => a.carModel.localeCompare(b.carModel));
            this.vehicles.forEach(x => {
                output.push(`${x.carModel} == ${x.carNumber} - ${x.payed == true ? 'Has payed' : 'Not payed'}`);
            });

            return output.join('\n');
        } else {
            const car = this.vehicles.find(x => x.carNumber == carNumber);

            return `${car.car} == ${car.carNumber} - ${car.payed == true ? 'Has payed' : 'Not payed'}`;
        }
    }

}

const parking = new Parking(12);

console.log(parking.addCar("Volvo t600", "TX3691CA"));
console.log(parking.getStatistics());

console.log(parking.pay("TX3691CA"));
console.log(parking.removeCar("TX3691CA"));
