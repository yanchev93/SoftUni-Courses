function tickets(arrInput, sortCriteria) {
    let result = [];
    const sortBy = sortCriteria;

    class Ticket {
        constructor(destination, price, status) {
            this.destination = destination;
            this.price = price;
            this.status = status;
        }
    }

    for (const data of arrInput) {
        const currData = data.split('|');
        let destination = currData[0];
        let price = Number(currData[1]);
        let status = currData[2];

        let currTicket = new Ticket(destination, price, status);
        result.push(currTicket);
    }

    if (sortBy == 'destination' || sortBy == 'status') {
        result.sort((a, b) => a[sortBy].localeCompare(b[sortBy]));
    } else {
        result.sort((a, b) => a - b);
    }
    return result;
}

console.log(tickets(['Philadelphia|94.20|available',
    'New York City|95.99|available',
    'New York City|95.99|sold',
    'Boston|126.20|departed'],
    'destination'
));

console.log(tickets(['Philadelphia|94.20|available',
    'New York City|95.99|available',
    'New York City|95.99|sold',
    'Boston|126.20|departed'],
    'status'
));