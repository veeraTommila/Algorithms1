# Algorithm projects.
University projects made with large variety of programming languages like C#, Python and Java.

This work is licensed under the terms of the MIT license. See the [MIT License](LICENSE) for more details.

## Demo task number 1.

The assignment was to design an algorithm that checks whether an integer is evenly divisible by another integer without using any division operations.

[Demo1a](https://github.com/veeraTommila/Algorithms1/blob/main/EvenlyDivisibleProject/Program.cs)

In this assignment one must find out that the given numbers a, b, and c are integers. There are no commas or periods in integers. One has to multiply the integers b and c together so that the result is a. It can be done like this by comparing the products b * c and c * b with each other. Everything is fine if the products are the same for both.

## Demo task number 2.

In the first task, a table contains numbers in random order. One needs to design an algorithm that calculates the difference between the largest and smallest numbers in the table. Then one needs to evaluate how the execution time depends on the size of the table.

[Demo2a](https://github.com/veeraTommila/Algorithms1/blob/main/Find_the_largest_and_smallest_from_the_table_Console_App/Program.cs)

This task is an example of a linear algorithm that solves the problem of finding the maximum and minimum values in an array. Since each element is checked once, the time complexity of the algorithm is: Best case: O(n) (if all numbers are the same, all are still checked) Worst case: O(n) Average case: O(n).

Go through the array in random order completely, and in each round, always look at one number at a time. Create a variable in which you always store the largest number found before the start of a new round. Compare the number from the new round to this largest number already found. If it is larger, set it as the new largest number. Also create a variable in which you always store the smallest number found before the start of a new round. Compare the number from the new round to the smallest number already found. If it is smaller, set it as the new smallest number. Finally, calculate the difference between the largest and smallest numbers in the array. The execution time in this case varies approximately depending on how many starts there are in the array = in this case, numbers. A larger array will require a longer execution time than a smaller array. In this case, the loop body is always executed n -
1 times (count - 1).

In the second task the table contains positive numbers in order of magnitude (numbers of the same magnitude in a row). One designs an algorithm that zeroes all "duplicates", in other words, only one copy of each positive number remains in the table, and the other positions are filled with zero. In addition, the number of zeroed numbers is counted. One estimates how the execution time depends on the size of the table.

[Demo2b](https://github.com/veeraTommila/Algorithms1/blob/main/Demo2bConsoleApp/Program.cs)
