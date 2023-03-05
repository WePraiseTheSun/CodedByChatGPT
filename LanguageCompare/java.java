public class Main {
    public static void main(String[] args) {
        // If statement
        int x = 10;
        if (x > 5) {
            System.out.println("x is greater than 5");
        }

        // If-Else statement
        int y = 3;
        if (y > 5) {
            System.out.println("y is greater than 5");
        } else {
            System.out.println("y is less than or equal to 5");
        }

        // Else-If statement
        int z = 8;
        if (z < 5) {
            System.out.println("z is less than 5");
        } else if (z <= 10) {
            System.out.println("z is between 5 and 10");
        } else {
            System.out.println("z is greater than 10");
        }

        // While loop
        int i = 1;
        while (i <= 5) {
            System.out.println(i);
            i++;
        }

        // Do-While loop
        int j = 1;
        do {
            System.out.println(j);
            j++;
        } while (j <= 5);

        // For loop
        for (int k = 0; k < 5; k++) {
            System.out.println(k);
        }

        // Continue statement
        for (int l = 0; l < 5; l++) {
            if (l == 2) {
                continue;
            }
            System.out.println(l);
        }

        // Break statement
        for (int m = 0; m < 10; m++) {
            if (m == 5) {
                break;
            }
            System.out.println(m);
        }

        // Switch statement
        int n = 8;
        switch (n) {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
                System.out.println("n is less than 5");
                break;
            case 6:
            case 7:
            case 8:
            case 9:
            case 10:
                System.out.println("n is between 5 and 10");
                break;
            default:
                System.out.println("n is greater than 10");
                break;
        }

        // Return statement
        System.out.println(getResult(8));
    }

    public static String getResult(int n) {
        if (n < 5) {
            return "n is less than 5";
        } else if (n <= 10) {
            return "n is between 5 and 10";
        } else {
            return "n is greater than 10";
        }
    }
}
