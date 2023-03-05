#!/bin/sh

get_result() {
    n=$1
    if [ $n -lt 5 ]; then
        echo "n is less than 5"
    elif [ $n -le 10 ]; then
        echo "n is between 5 and 10"
    else
        echo "n is greater than 10"
    fi
}

# If statement
x=10
if [ $x -gt 5 ]; then
    echo "x is greater than 5"
fi

# If-Else statement
y=3
if [ $y -gt 5 ]; then
    echo "y is greater than 5"
else
    echo "y is less than or equal to 5"
fi

# Else-If statement
z=8
if [ $z -lt 5 ]; then
    echo "z is less than 5"
elif [ $z -le 10 ]; then
    echo "z is between 5 and 10"
else
    echo "z is greater than 10"
fi

# While loop
i=1
while [ $i -le 5 ]; do
    echo $i
    i=$((i+1))
done

# Until loop
j=1
until [ $j -gt 5 ]; do
    echo $j
    j=$((j+1))
done

# For loop
for k in 0 1 2 3 4; do
    echo $k
done

# Continue statement
for l in 0 1 2 3 4; do
    if [ $l -eq 2 ]; then
        continue
    fi
    echo $l
done

# Break statement
for m in 0 1 2 3 4 5 6 7 8 9; do
    if [ $m -eq 5 ]; then
        break
    fi
    echo $m
done

# Case statement
n=8
case $n in
    [1-5]) echo "n is less than 5";;
    [6-10]) echo "n is between 5 and 10";;
    *) echo "n is greater than 10";;
esac

# Return statement
get_result 8
