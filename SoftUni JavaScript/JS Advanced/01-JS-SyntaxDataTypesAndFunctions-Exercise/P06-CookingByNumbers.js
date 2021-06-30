function cookNums(...input) {
    let num = input.shift();

    input.forEach(x => {
        if (x == 'chop') {
            num /= 2;
        } else if (x == 'dice') {
            num = Math.sqrt(num);
        } else if (x == 'spice') {
            num += 1;
        } else if (x == 'bake') {
            num *= 3;
        } else if (x == 'fillet') {
            num *= 0.80;
        }

        console.log(num);
    })
}

cookNums('32', 'chop', 'chop', 'chop', 'chop', 'chop');
cookNums('9', 'dice', 'spice', 'chop', 'bake', 'fillet');