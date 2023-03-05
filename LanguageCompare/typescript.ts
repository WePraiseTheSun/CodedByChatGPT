// If statement
let x: number = 10;
if (x > 5) {
    console.log('x is greater than 5');
}

// If-Else statement
let y: number = 3;
if (y > 5) {
    console.log('y is greater than 5');
} else {
    console.log('y is less than or equal to 5');
}

// Switch statement
let z: number = 8;
switch (z) {
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        console.log('z is less than 5');
        break;
    case 6:
    case 7:
    case 8:
    case 9:
    case 10:
        console.log('z is between 5 and 10');
        break;
    default:
        console.log('z is greater than 10');
        break;
}

// For-in loop
let numbers: number[] = [1, 2, 3, 4];
for (let i in numbers) {
    console.log(numbers[i]);
}

// For-of loop
let names: string[] = ['Alice', 'Bob', 'Charlie'];
for (let name of names) {
    console.log(name);
}

// While loop
let j: number = 1;
while (j <= 5) {
    console.log(j);
    j++;
}

// Do-While loop
let k: number = 1;
do {
    console.log(k);
    k++;
} while (k <= 5);

// Continue statement
for (let l: number = 1; l <= 5; l++) {
    if (l == 3) {
        continue;
    }
    console.log(l);
}

// Break statement
for (let m: number = 1; m <= 10; m++) {
    if (m == 5) {
        break;
    }
    console.log(m);
}

// Return statement
console.log(getResult());

// Label statement
outer: for (let n: number = 1; n <= 3; n++) {
    for (let o: number = 1; o <= 3; o++) {
        if (n == 2 && o == 2) {
            break outer;
        }
        console.log(n, o);
    }
}

function getResult(): string {
    let p: number = 8;
    switch (p) {
        case 1:
        case 2:
        case 3:
        case 4:
        case 5:
            return 'p is less than 5';
        case 6:
        case 7:
        case 8:
        case 9:
        case 10:
            return 'p is between 5 and 10';
        default:
            return 'p is greater than 10';
    }
}
