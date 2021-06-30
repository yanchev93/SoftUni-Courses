class List {
    constructor() {
        this.list = [];
        this.size = 0;
    }

    add(el) {
        this.list.push(el);
        this.list.sort((a, b) => a - b);
        this.size += 1;
        return;
    }

    remove(i) {
        if (i < 0 || this.size <= i) {
            return;
        }
        this.list.splice(i, 1);
        this.size -= 1;
        return;
    }

    get(i) {
        if (i < 0 || this.size <= i) {
            return;
        }
        this.list.sort((a, b) => a - b);
        return this.list[i];
    }
}

// class List {
//     constructor() {
//         this.arr = []
//         this.size = 0
//     }

//     add(element) {
//         this.arr.push(element)
//         this.size += 1
//         return this.arr.sort((a, b) => {
//             return a - b
//         })
//     }

//     remove(index) {
//         if (this.arr.length > index && index >= 0) {
//             this.arr.splice(index, 1)
//             this.size--
//         } else {
//             throw new Error
//         }
//         return this.arr.sort((a, b) => {
//             return a - b
//         })
//     }

//     get(index) {
//         if (this.arr.length > index && index >= 0) {
//             return this.arr[index]
//         } else {
//             throw new Error
//         }
//     }
// }

let list = new List();
list.add(6);
list.add(7);
list.add(7);
list.add(7);
list.add(7);
list.add(7);
list.add(5);
console.log(list.get(2)); // 7
list.remove(1); // remove 6
console.log(list.get(0));
console.log(list.size);
