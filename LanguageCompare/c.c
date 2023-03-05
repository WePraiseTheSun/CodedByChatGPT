#include <stdio.h>

char* getResult(int n);

int main() {
    // If statement
    int x = 10;
    if (x > 5) {
        printf("x is greater than 5\n");
    }

    // If-Else statement
    int y = 3;
    if (y > 5) {
        printf("y is greater than 5\n");
    } else {
        printf("y is less than or equal to 5\n");
    }

    // Else-If statement
    int z = 8;
    if (z < 5) {
        printf("z is less than 5\n");
    } else if (z <= 10) {
        printf("z is between 5 and 10\n");
    } else {
        printf("z is greater than 10\n");
    }

    // While loop
    int i = 1;
    while (i <= 5) {
        printf("%d\n", i);
        i++;
    }

    // Do-While loop
    int j = 1;
    do {
        printf("%d\n", j);
        j++;
    } while (j <= 5);

    // For loop
    for (int k = 0; k < 5; k++) {
        printf("%d\n", k);
    }

    // Continue statement
    for (int l = 0; l < 5; l++) {
        if (l == 2) {
            continue;
        }
        printf("%d\n", l);
    }

    // Break statement
    for (int m = 0; m < 10; m++) {
        if (m == 5) {
            break;
        }
        printf("%d\n", m);
    }

    // Switch statement
    int n = 8;
    switch (n) {
        case 1:
        case 2:
        case 3:
        case 4:
        case 5:
            printf("n is less than 5\n");
            break;
        case 6:
        case 7:
        case 8:
        case 9:
        case 10:
            printf("n is between 5 and 10\n");
            break;
        default:
            printf("n is greater than 10\n");
            break;
    }

    // Return statement
    printf("%s\n", getResult(8));

    return 0;
}

char* getResult(int n) {
    if (n < 5) {
        return "n is less than 5";
    } else if (n <= 10) {
        return "n is between 5 and 10";
    } else {
        return "n is greater than 10";
    }
}
