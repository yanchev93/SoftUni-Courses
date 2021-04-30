function time(steps, stepLength, kmPerH) {
    let distance = steps * stepLength;
    let speedInMetersPerSec = kmPerH / 3.6;

    let rest = Math.floor(distance / 500);
    let timeInSeconds = distance / speedInMetersPerSec + rest * 60;

    let timeInHours = Math.floor(timeInSeconds / 3600);
    let timeInMins = Math.floor(timeInSeconds / 60);
    let timeInSecs = Math.ceil(timeInSeconds % 60);

    console.log(`${timeInHours < 10 ? 0 : ""}${timeInHours}:${timeInMins < 10 ? 0 : ""}${timeInMins}:${timeInSecs < 10 ? 0 : ""}${timeInSecs}`);;
}

time(4000, 0.60, 5);
time(2564, 0.70, 5.5);