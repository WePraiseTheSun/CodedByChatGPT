// If statement
var x = 10
if x > 5 {
    print("x is greater than 5")
}

// If-Else statement
var y = 3
if y > 5 {
    print("y is greater than 5")
} else {
    print("y is less than or equal to 5")
}

// Switch statement
var z = 8
switch z {
case ..<5:
    print("z is less than 5")
case 5..<10:
    print("z is between 5 and 10")
default:
    print("z is greater than or equal to 10")
}

// For-in loop
for i in 1...4 {
    print(i)
}

// While loop
var j = 1
while j <= 5 {
    print(j)
    j += 1
}

// Repeat-While loop
var k = 1
repeat {
    print(k)
    k += 1
} while k <= 5

// Continue statement
for l in 1...5 {
    if l == 3 {
        continue
    }
    print(l)
}

// Break statement
for m in 1...10 {
    if m == 5 {
        break
    }
    print(m)
}

// Fallthrough statement
let n = 8
switch n {
case 1...5:
    print("n is between 1 and 5")
    fallthrough
case 6...10:
    print("n is between 6 and 10")
default:
    print("n is greater than 10")
}
