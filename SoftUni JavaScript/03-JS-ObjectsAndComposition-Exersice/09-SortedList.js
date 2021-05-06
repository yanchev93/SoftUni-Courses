function createSortedList() {
    arr = [];

    function add(element) {
        arr.push(element);
        this.size += 1;
        arr.sort((a, b) => a - b);
    }
    function remove(index) {
        arr.splice(index, 1);
        this.size -= 1;
        arr.sort((a, b) => a - b);
    }
    function get(index) {
        return arr[index];
    }
    let list = {
        add,
        remove,
        get,
        size: 0
    };

    return list;
}

let list = createSortedList();

list.add(5);
list.add(6);
list.add(7);

console.log(list.get(1));

list.remove(1);

console.log(list.get(1));

console.log('');

console.log(list.size);

console.log(list);