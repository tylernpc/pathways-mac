const dog = {
    name: 'fido',
    age: 4,
    bark () {
        console.log('woof');
    }
}

// dot notation
// const name = dog.name;
// const age = dog.age;
// console.log(name, age);

// destructuring
const { name, age } = dog;

// another destructuring example / both do the same thing, but line 20 is shorthand of 19 where the placement matters
const arr = ['foo', 'bar', 'baz'];
// const [,, c] = arr;
const c = arr[2];

dog.bark();