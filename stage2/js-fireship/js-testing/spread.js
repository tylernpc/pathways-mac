// this is for the spread operator

// combine two objects or arrays together
const obj1 = {
    first: 'a',
    second: 'b',
    third: 'c',
}

const obj2 = {
    third: 'd',
    fourth: 'e',
}

const full = Object.assign({}, obj1, obj2);
const newFull = {...obj1, ...obj2}; // spread syntax
// in this case obj2 would take priority and third would be d


// also spread syntax
const obj3 = {
    ten: 'a',
    eleven: 'b',
    twelve: 'c',
}

const obj4 = {
    ...obj3,
    twelve: 'n',
    thirteen: 'd',
}
// NOTE: depending on where you put the spread syntax will overwrite certain things. in this case c from obj3 is overwritten