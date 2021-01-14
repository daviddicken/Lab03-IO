# Lab03-I/O

**Author**: David Dicken
**Version**: 1.4.0 

## Overview
This is a group of code challenges done pair programming.
When you run this program 7 methods will fire off:

## Product of Three
Will ask you for three numbers seperated by spaces and return the product of those numbers.
If you enter a non number the program will give you a message and return 0.
If you did not enter enough numbers the program will also return 0

## Average Number
Will ask you for a number between 2-10. If you do not enter a number between 2-10 you will be asked again.
Then you will be asked for a number as many times as the number you selected in the previous step.
Same thing if you give a non number or a negative you will be asked again.
Finally the program will display the average of the numbers you entered.

## Print Pattern
This will print out a diamond made out of *'s to the screen

## Most Duplicates
Will take in an array of ints. We will be passing in [20, 20, 30, 31, 13, 12, 13].
It will step through the array and find the number that appears the most.
In case of a tie the first number found should be returned.
In our case 20 should be returned.

## Max Value
This method also takes in an array of ints. We will be passing in [20, 20, 30, 31, 13, 12, 13] again.
This method will step through the array and return the largest value found.
In this case it should return 31

## Write to file
Our next method will ask you for a string you would like to have saved to our words.txt file.
And it will save it to that file.

## Read file
This method will read the file you just created.

## Example
Challenge 1:
Please enter three numbers seperated by a space.
12 4 6
288

Challenge 2:
Please provide a number between 2 - 10: 2
1 of 2 - Enter a number: 1
2 of 2 - Enter a number: 2
The average of these 2 numbers is: 1.5

Challenge 3:
    *
   ***
  *****
********
  *****
   ***
    *


Challenge 4 passing in [20, 20, 30, 31, 13, 12, 13] should return 20
20

Challenge 5 passing in [20, 20, 30, 31, 13, 12, 13] should return 31
31

Challenge 7 writing to words file
What would you like to save to the words file?
1212

Challenge 6: reading from words file
1212

## Architecture
This app was built with Visual Studio using C#.

## Change Log
01-13-2021 Created ProductOfThree method and test with Ameilia.
01-13-2021 Created MedianNumber method with Matthew.
01-13-2021 Created PrintPattern method with Mike.
01-13-2021 Created MostDuplicates method with Ameilia.
01-13-2021 Created Challenge5 method with JP.
01-13-2021 Created WriteToFile and ReadFromFiles with Scott.
01-13-2021 Completed README