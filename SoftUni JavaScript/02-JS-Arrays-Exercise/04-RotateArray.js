function rotate(array){
    let n = Number(array.pop()) % 100;

    for (let i = 0; i < n; i++) {
        array.unshift(array.pop());
    }

    return array.join(' ');
}

console.log(rotate(['1', 
'2', 
'3', 
'4', 
'2']
));

console.log('');

console.log(rotate(['Banana', 
'Orange', 
'Coconut', 
'Apple', 
'15']
));