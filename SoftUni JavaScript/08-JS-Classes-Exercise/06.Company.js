class Company {
    constructor() {
        this.departmants = [];
        this.depObj = {};
    }

    addEmployee(username, salary, position, department) {
        if (!username || !salary || !position || !department) {
            throw new Error('Invalid input!');
        }

        if (salary < 0) {
            throw new Error('Invalid input!');
        }

        const employee = {
            username,
            salary,
            position,
            department
        };

        if (!this.depObj[department]) {
            this.depObj[department] = {};
            if (!this.depObj[department][salary]) {
                this.depObj[department].salary = 0;
                this.depObj[department].employees = 0;
            }
        }

        this.depObj[department].salary += salary;
        this.depObj[department].employees += 1;

        this.departmants.push(employee);

        return `New employee is hired. Name: ${username}. Position: ${position}`;
    }

    bestDepartment() {
        let bestDepName = '';
        let bestAvrSalary = 0;

        for (const dep of Object.entries(this.depObj)) {
            let [key, value] = dep;
            const avrSalarayByDep = value.salary / value.employees;
            if (bestAvrSalary < avrSalarayByDep) {
                bestAvrSalary = avrSalarayByDep;
                bestDepName = key;
            }
        }

        const bestEmployees = this.departmants
            .filter(x => x.department == bestDepName)
            .sort((a, b) => a.username.localeCompare(b.username))
            .sort((a, b) => b.salary - a.salary);


        let output = [];
        output.push(`Best Department is: ${bestDepName}`);
        output.push(`Average salary: ${bestAvrSalary.toFixed(2)}`);
        bestEmployees.forEach(x => {
            output.push(`${x.username} ${x.salary} ${x.position}`);
        });

        return output.join('\n');
    }
}

let c = new Company();
c.addEmployee("Stanimir", 2000, "engineer", "Human resources");
c.addEmployee("Pesho", 1500, "electrical engineer", "Construction");
c.addEmployee("Slavi", 500, "dyer", "Construction");
c.addEmployee("Stan", 2000, "architect", "Construction");
c.addEmployee("Stanimir", 1200, "digital marketing manager", "Marketing");
c.addEmployee("Pesho", 1000, "graphical designer", "Marketing");
c.addEmployee("Gosho", 1350, "HR", "Human resources");

console.log(c.bestDepartment());

// let c = new Company();
// c.addEmployee("Stanimir", 2000, "engineer", "Construction");
// c.addEmployee("Pesho", 1500, "electrical engineer", "Construction");
// c.addEmployee("Slavi", 500, "dyer", "Construction");
// c.addEmployee("Stan", 2000, "architect", "Construction");
// c.addEmployee("Stanimir", 1200, "digital marketing manager", "Marketing");
// c.addEmployee("Pesho", 1000, "graphical designer", "Marketing");
// c.addEmployee("Gosho", 1350, "HR", "Human resources");
// console.log(c.bestDepartment());
