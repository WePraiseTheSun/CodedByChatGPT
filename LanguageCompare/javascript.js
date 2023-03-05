// If statement
let x = 10;
if (x > 5) {
    console.log('x is greater than 5');
}

// If-Else statement
let y = 3;
if (y > 5) {
    console.log('y is greater than 5');
} else {
    console.log('y is less than or equal to 5');
}

// Else-If statement
let z = 8;
if (z < 5) {
    console.log('z is less than 5');
} else if (z <= 10) {
    console.log('z is between 5 and 10');
} else {
    console.log('z is greater than 10');
}

// While loop
let i = 1;
while (i <= 5) {
    console.log(i);
    i++;
}

// Do-While loop
let j = 1;
do {
    console.log(j);
    j++;
} while (j <= 5);

// For loop
for (let k = 0; k < 5; k++) {
    console.log(k);
}

// Continue statement
for (let l = 0; l < 5; l++) {
    if (l == 2) {
        continue;
    }
    console.log(l);
}

// Break statement
for (let m = 0; m < 10; m++) {
    if (m == 5) {
        break;
    }
    console.log(m);
}

// Switch statement
let n = 8;
switch (n) {
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        console.log('n is less than 5');
        break;
    case 6:
    case 7:
    case 8:
    case 9:
    case 10:
        console.log('n is between 5 and 10');
        break;
    default:
        console.log('n is greater than 10');
        break;
}

// Return statement
console.log(getResult(8));

function getResult(n) {
    if (n < 5) {
        return 'n is less than 5';
    } else if (n <= 10) {
        return 'n is between 5 and 10';
    } else {
        return 'n is greater than 10';
    }
}
