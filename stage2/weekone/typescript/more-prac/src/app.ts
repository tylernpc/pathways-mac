/*
let sales: number = 123_456_789; // you can separate digits using a(n) underscore i guess
let course: string = 'TypeScript';
let is_published: boolean = true; 
*/ // THIS IS ONE WAY TO DO IT, KIND OF EXPLICITLY TELLING THE MACHINE WHAT IS WHAT
let sales = 123_456_789;
let course = 'TypeScript';
let is_published = true;
let level; // TS Assumes that the type for this is any as there's not a lot to go on
// THIS IS ANOTHER WAY TO DO IT, THIS IMPLICIT DECLARATION AND DOES THE SAME THING WITHOUT BEING TOLD EXPLICITLY

let user: [number, string] = [1, 'Tyler']; // Tuple

// enum
const small = 1;
const medium = 2;
const large = 3;

// PascalCase
// enum Size {Small, Medium, Large} Initially the code will assign small to 0
// enum Size {Small = 's', Medium = 'm', Large = 'l'}; 
const enum Size { Small = 1, Medium, Large }; // the other assignments know what to do
let mySize: Size = Size.Medium;
console.log(mySize);

function calculateTax(income: number, taxYear = 2022): number {
    if (taxYear < 2022)
        return income * 1.2;
    return income * 1.3
}

calculateTax(10_000, 2022);

// objects
// type alias
type Employee = {
    readonly id: number,
    name: string,
    retire: (date: Date) => void
}

let employee: Employee = { 
    id: 1, 
    name: 'Tyler',
    retire: (date: Date) => {
        console.log(date);
    }
};

// union types
function kgToLbs(weight: number | string): number {
    // narrowing
    if (typeof weight === 'number')
        return weight * 2.2;
    else {
        return parseInt(weight) * 2.2;
    }
}

kgToLbs(10);
kgToLbs('10kg');

// intersection types
type Draggable = {
    drag: () => void
};

type Resizable = {
    resize: () => void
};

type UIWidget = Draggable & Resizable;

let textBox: UIWidget = {
    drag: () => {},
    resize: () => {}
};

// literal types
type Quantity = 50 | 100; // literal type, can be a string also
let quantity: Quantity = 50;

type Metric = 'cm' | 'inch';

// nullable types
function greet(name: string | null | undefined) {
    if (name)
        console.log(name.toUpperCase());
    else
        console.log('Hola!');
}

greet(undefined); 

type Customer = {
    birthday: Date
};
// optional chaining
function getCustomer(id: number): Customer | null | undefined {
    return id === 0 ? null : { birthday: new Date() };
}

let customer = getCustomer(0);
if (customer !== null && customer !== undefined)
    console.log(customer.birthday);

// or
console.log(customer?.birthday?.getFullYear); // executed only if customer is not null or undefined