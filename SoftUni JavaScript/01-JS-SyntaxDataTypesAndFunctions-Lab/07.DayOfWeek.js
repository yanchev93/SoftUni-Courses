function solve(dayOfWeek) {
    let day;
    let inputDay = dayOfWeek;

    if (inputDay === 'Monday') {
        day = 1;
    } else if (inputDay === 'Tuesday') {
        day = 2;
    } else if (inputDay === 'Wednesday') {
        day = 3;
    } else if (inputDay === 'Thursday') {
        day = 4;
    } else if (inputDay === 'Friday') {
        day = 5;
    } else if (inputDay === 'Saturday') {
        day = 6;
    } else if (inputDay === 'Sunday') {
        day = 7;
    } else {
        day = 'error';
    }

    console.log(day);
}

solve('Monday');
solve('Invalid');
solve(1);