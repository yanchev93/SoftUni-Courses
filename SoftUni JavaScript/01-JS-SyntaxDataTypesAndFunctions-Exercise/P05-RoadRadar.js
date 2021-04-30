function radar(speed, area) {
    let result = "";
    let speeding = speed + 20;
    let excSpeeding = speed + 40;

    if (area === 'residential' && 20 < speed) {
        if (speed <= 40) {
            result += 'speeding';
        } else if (speed <= 60) {
            result += 'excessive speeding';
        } else if (60 < speed) {
            result += 'reckless driving';
        }else {
            result += `Driving ${speed} km/h in a 20 zone`;
        }
    } else if (area === 'city' && 50 < speed) {
        if (speed <= 70) {
            result += 'speeding';
        } else if (speed <= 90) {
            result += 'excessive speeding';
        } else if (90 < speed){
            result += 'reckless driving';
        } else {
            result += `Driving ${speed} km/h in a 50 zone`;
        }
    } else if (area === 'interstate' && 90 < speed) {
        if (speed <= 110) {
            result += 'speeding';
        } else if (speed <= 130) {
            result += 'excessive speeding';
        } else if (130 < speed){
            result += 'reckless driving';
        }else {
            result += `Driving ${speed} km/h in a 90 zone`;
        }
    } else if (area === 'motorway' && 130 < speed) {
        if (speed <= 150) {
            result += 'speeding';
        } else if (speed <= 170) {
            result += 'excessive speeding';
        } else if (170 < speed){
            result += 'reckless driving';
        }else {
            result += `Driving ${speed} km/h in a 130 zone`;
        }
    }

    console.log(result);
}

radar(40, 'city');
radar(21, 'residential');
radar(120, 'interstate');
radar(200, 'motorway');