#include <iostream>

using namespace std;

int main() {
    // If statement
    int x = 10;
    if (x > 5) {
        cout << "x is greater than 5" << endl;
    }

    // If-Else statement
    int y = 3;
    if (y > 5) {
        cout << "y is greater than 5" << endl;
    } else {
        cout << "y is less than or equal to 5" << endl;
    }

    // Else-If statement
    int z = 8;
    if (z < 5) {
        cout << "z is less than 5" << endl;
    } else if (z <= 10) {
        cout << "z is between 5 and 10" << endl;
    } else {
        cout << "z is greater than 10" << endl;
    }

    // While loop
    int i = 1;
    while (i <= 5) {
        cout << i << endl;
        i++;
    }

    // Do-While loop
    int j = 1;
    do {
        cout << j << endl;
        j++;
    } while (j <= 5);

    // For loop
    for (int k = 0; k < 5; k++) {
        cout << k << endl;
    }

    // Continue statement
    for (int l = 0; l < 5; l++) {
        if (l == 2) {
            continue;
        }
        cout << l << endl;
    }

    // Break statement
    for (int m = 0; m < 10; m++) {
        if (m == 5) {
            break;
        }
        cout << m << endl;
    }

    // Switch statement
    int n = 8;
    switch (n) {
        case 1:
        case 2:
        case 3:
        case 4:
        case 5:
            cout << "n is less than 5" << endl;
            break;
        case 6:
        case 7:
        case 8:
        case 9:
        case 10:
            cout << "n is between 5 and 10" << endl;
            break;
        default:
            cout << "n is greater than 10" << endl;
            break;
    }

    // Goto statement
    int p = 1;
loop:
    cout << p << endl;
    p++;
    if (p <= 5) {
        goto loop;
    }

    // Return statement
    cout << getResult(8) << endl;

    return 0;
}

string getResult(int n) {
    if (n < 5) {
        return "n is less than 5";
    } else if (n <= 10) {
        return "n is between 5 and 10";
    } else {
        return "n is greater than 10";
    }
}
