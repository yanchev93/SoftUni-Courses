function solve() {
   document.querySelector('#btnSend').addEventListener('click', onClick);
   const restaurants = document.querySelector('textarea');

   let bestOutput = document.querySelector('#bestRestaurant>p');
   let bestWorkers = document.querySelector('#workers>p');

   function onClick() {
      let arr = JSON.parse(restaurants.value);

      let restaurantsObj = {};

      arr.forEach(restaurant => {

         const currentRestaurant = restaurant.split(' - ');
         const name = currentRestaurant[0];
         const employes = currentRestaurant[1].split(', ');
         let workers = [];

         for (let worker of employes) {
            const currentWorker = worker.split(' ');
            let workerName = currentWorker[0];
            let workerSalary = Number(currentWorker[1]);

            workers.push({
               name: workerName,
               salary: workerSalary
            });
         }

         if (restaurantsObj[name]) {
            workers = workers.concat(restaurantsObj[name].workers);
         }

         workers.sort((a, b) => b.salary - a.salary);
         const bestSalary = workers[0].salary;
         const avrSalary = workers.reduce((sum, worker) => sum + worker.salary, 0) / workers.length;

         restaurantsObj[name] = {
            workers,
            avrSalary,
            bestSalary
         }
      });

      let bestRestaurantSalary = 0;
      let best = undefined;
      for (const name in restaurantsObj) {
         if (bestRestaurantSalary <= restaurantsObj[name].avrSalary) {
            best = {
               name,
               workers: restaurantsObj[name].workers,
               bestSalary: restaurantsObj[name].bestSalary,
               avrSalary: restaurantsObj[name].avrSalary
            };
         }

         bestRestaurantSalary = restaurantsObj[name].avrSalary;
      }

      bestOutput.textContent =
         `Name: ${best.name} Average Salary: ${best.avrSalary.toFixed(2)} Best Salary: ${best.bestSalary.toFixed(2)}`;

      let output = [];
      for (const worker of best.workers) {
         output.push(`Name: ${worker.name} With Salary: ${worker.salary}`);
      }

      bestWorkers.innerHTML = output.join(' ');
   }
}