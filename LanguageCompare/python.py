# if statement
x = 10
if x > 5:
    print("x is greater than 5")

# if-else statement
y = 3
if y > 5:
    print("y is greater than 5")
else:
    print("y is less than or equal to 5")

# if-elif-else statement
z = 8
if z > 10:
    print("z is greater than 10")
elif z > 5:
    print("z is greater than 5 but less than or equal to 10")
else:
    print("z is less than or equal to 5")

# for loop
for i in range(1, 5):
    print(i)

# while loop
j = 1
while j <= 5:
    print(j)
    j += 1

# do-while loop
k = 1
while True:
    print(k)
    k += 1
    if k > 5:
        break

# break statement
for l in range(1, 10):
    if l == 5:
        break
    print(l)

# continue statement
for m in range(1, 6):
    if m == 3:
        continue
    print(m)

# pass statement
for n in range(1, 6):
    if n == 3:
        pass
    print(n)
