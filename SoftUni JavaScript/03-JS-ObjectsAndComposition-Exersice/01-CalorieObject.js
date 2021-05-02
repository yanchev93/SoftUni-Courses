function calories(arr) {
    
    let calorieObj = {};

    for (i = 0; i < arr.length; i += 2){
        let name = arr[i];
        let calorie = Number(arr[i + 1]);

        calorieObj[name] = calorie;
    }

    return calorieObj;
}

console.log(calories(
    ['Yoghurt', '48', 'Rise', '138', 'Apple', '52']
));