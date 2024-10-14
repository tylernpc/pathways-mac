// create a range of numbers
const longRange = Array(100).fill(0).map((_, i) => i + 1);
// a bit of a more concise way to do it
const shortRange = [...Array(100).keys()];

// remove duplicates from an array
const unique = [...new Set(arr)];

// recieve a random element
const random = arr[Math.floor(Math.random() * arr.length)];

arr.forEach();
arr.map();
arr.filter();
arr.find();
arr.findIndex();
arr.reduce();