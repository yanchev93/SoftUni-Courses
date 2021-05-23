function solve() {
    let text = '';

    let textObj = {
        append,
        removeStart,
        removeEnd,
        print
    };

    function append(string) {
        text += string;
    }

    function removeStart(n) {
        text = text.substring(n);
    }

    function removeEnd(n) {
        text = text.substring(0, text.length - n);
    }

    function print() {
        console.log(text);
    }

    return textObj;
}

let firstString = solve();

firstString.append('hello');
firstString.append('again');
firstString.removeStart(3);
firstString.removeEnd(4);
firstString.print();
