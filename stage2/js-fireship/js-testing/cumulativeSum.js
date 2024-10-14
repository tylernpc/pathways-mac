// create a function that takes an array of numbers and returns a number that is the sum of all values in the array
let mainNum = 0;
let cumulativeNum;
const mainArray = [1, 2, 3];

function cumulativeArray(arr) {
    for (let i = 0; i < arr.length; i++) {
        mainNum += arr[i];
    }
    return mainNum;
}

console.log(cumulativeArray(mainArray));