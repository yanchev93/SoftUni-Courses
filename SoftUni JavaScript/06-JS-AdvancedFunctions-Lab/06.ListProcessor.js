function solve(input) {
    let myList = [];

    let objList = {
        add,
        remove,
        print
    };

    function add(string) {
        myList.push(string);
    }

    function remove(string) {
        myList = myList.filter(x => x != string);
    }

    function print() {
        console.log(myList.join(','));
    }

    [...input].forEach(x => {
        let currentInput = x.split(' ');
        let command = currentInput[0];
        let text = currentInput[1];

        objList[command](text);
    });
}

solve(['add hello', 'add again', 'remove hello', 'add again', 'print']);

console.log('----------!!!!!-----------');

solve(['add pesho', 'add george', 'add peter', 'remove peter', 'print']);