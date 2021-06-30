function inventory(arr) {
    let output = [];

    for (let i = 0; i < arr.length; i++) {
        let array = arr[i].split(' / ');
        
        let [name, level, items] = array;
        level = Number(level);
        items = items ? items.split(', ') : [];

        let hero ={
            name,
            level,
            items
        }
        
        output.push(hero);

    }

    return JSON.stringify(output);
}

console.log(inventory(
    ['Isacc / 25 / Apple, GravityGun',
        'Derek / 12 / BarrelVest, DestructionSword',
        'Hes / 1 / Desolator, Sentinel, Antara']

));