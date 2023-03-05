void main() {
	// If statement
	var x = 10;
	if (x > 5) {
	  print('x is greater than 5');
	}
  
	// If-Else statement
	var y = 3;
	if (y > 5) {
	  print('y is greater than 5');
	} else {
	  print('y is less than or equal to 5');
	}
  
	// Switch statement
	var z = 8;
	switch (z) {
	  case 1:
	  case 2:
	  case 3:
	  case 4:
	  case 5:
		print('z is less than 5');
		break;
	  case 6:
	  case 7:
	  case 8:
	  case 9:
	  case 10:
		print('z is between 5 and 10');
		break;
	  default:
		print('z is greater than 10');
		break;
	}
  
	// For-in loop
	var numbers = [1, 2, 3, 4];
	for (var i in numbers) {
	  print(i);
	}
  
	// While loop
	var j = 1;
	while (j <= 5) {
	  print(j);
	  j++;
	}
  
	// Do-While loop
	var k = 1;
	do {
	  print(k);
	  k++;
	} while (k <= 5);
  
	// Continue statement
	for (var l = 1; l <= 5; l++) {
	  if (l == 3) {
		continue;
	  }
	  print(l);
	}
  
	// Break statement
	for (var m = 1; m <= 10; m++) {
	  if (m == 5) {
		break;
	  }
	  print(m);
	}
  
	// Return statement
	print(getResult());
  }
  
  String getResult() {
	var n = 8;
	switch (n) {
	  case 1:
	  case 2:
	  case 3:
	  case 4:
	  case 5:
		return 'n is less than 5';
	  case 6:
	  case 7:
	  case 8:
	  case 9:
	  case 10:
		return 'n is between 5 and 10';
	  default:
		return 'n is greater than 10';
	}
  }
  