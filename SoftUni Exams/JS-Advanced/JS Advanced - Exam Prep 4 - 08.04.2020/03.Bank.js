class Bank {
    constructor(bankName) {
        this._bankName = bankName;
        this.allCustomers = [];
    }

    newCustomer({ firstName, lastName, personalId }) {
        const customer = this.allCustomers.find(x => x.firstName == firstName &&
            x.lastName == lastName && x.personalId == personalId);

        if (customer) {
            throw new Error(`${customer.firstName} ${customer.lastName} is already our customer!`);
        }

        this.allCustomers.push({ firstName, lastName, personalId });

        return { firstName, lastName, personalId };
    }

    depositMoney(personalId, amount) {
        this._checkCustomer(personalId);

        const customer = this.allCustomers.find(x => x.personalId == personalId);
        if (!customer.totalMoney) {
            customer.totalMoney = 0;
            customer.transactions = [];
        }

        customer.totalMoney += amount;

        let transactionNumber = customer.transactions.length + 1;
        let transaction = `. ${customer.firstName} ${customer.lastName} made deposit of ${amount}$`;
        let obj = { transactionNumber, transaction };

        customer.transactions.push(obj);

        return `${customer.totalMoney}$`;
    }

    withdrawMoney(personalId, amount) {
        this._checkCustomer(personalId);

        const customer = this.allCustomers.find(x => x.personalId == personalId);
        if (customer.totalMoney < amount) {
            throw new Error(`${customer.firstName} ${customer.lastName} does not have enough money to withdraw that amount!`);
        }

        customer.totalMoney -= amount;

        let transactionNumber = customer.transactions.length + 1;
        let transaction = `. ${customer.firstName} ${customer.lastName} withdrew ${amount}$`;
        let obj = { transactionNumber, transaction };

        customer.transactions.push(obj);

        return `${customer.totalMoney}$`;
    }

    customerInfo(personalId) {
        this._checkCustomer(personalId);

        let output = [];

        const customer = this.allCustomers.find(x => x.personalId == personalId);
        output.push(`Bank name: ${this._bankName}`);
        output.push(`Customer name: ${customer.firstName} ${customer.lastName}`);
        output.push(`Customer ID: ${customer.personalId}`);
        output.push(`Total Money: ${customer.totalMoney}$`);
        output.push(`Transactions:`);

        customer.transactions
            .sort((a, b) => b.transactionNumber - a.transactionNumber)
            .forEach((x, i) => {
                output.push(`${x.transactionNumber}${x.transaction}!`);
            });

        return output.join('\n');
    }

    _checkCustomer(personalId) {
        const customer = this.allCustomers.find(x => x.personalId == personalId);

        if (!customer) {
            throw new Error('We have no customer with this ID!');
        }
    }

}

let bank = new Bank('SoftUni Bank');

console.log(bank.newCustomer({ firstName: "Svetlin", lastName: 'Nakov', personalId: 6233267 }));
console.log(bank.newCustomer({ firstName: 'Mihaela', lastName: 'Mileva', personalId: 4151596 }));

bank.depositMoney(6233267, 250);
console.log(bank.depositMoney(6233267, 250));
bank.depositMoney(4151596, 555);

console.log(bank.withdrawMoney(6233267, 125));

console.log(bank.customerInfo(6233267));

