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

// faster way to do this
const sum = [1,2,3].reduce((acc, cur) => acc + cur);
// .reduce utilizes only one value, it then has the accumumated value and currnet value.
// it then uses an arrow function to add then current number to the accumulated number

console.log(cumulativeArray(mainArray));
console.log(sum);