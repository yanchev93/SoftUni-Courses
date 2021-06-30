function areNumbersSame(...numbers) {
    let sum = 0;
    let isSame = true;
    let nums = numbers.toString();

    for (let i = nums.length - 1; i >= 1; i--) {
        if (nums[i] == nums[i - 1]) {
            sum += Number(nums[i]);
        } else {
            isSame = false;
            sum += Number(nums[i]);
        }
    }

    sum += Number(nums[0]);

    console.log(isSame);
    console.log(sum);
}

areNumbersSame(2222222);
areNumbersSame(1234555)