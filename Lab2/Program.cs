using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1]
            //Write a C# program to print the multiplication table of a given number using the for loop.


            //Console.Write("Enter a number ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{n}*{i} = {n * i}");
            //}
            //Console.ReadLine();



            // 2]
            //Write a C# program to display a right-angled triangle pattern using nested for loops.



            //Console.Write("Enter the number of rows");
            //int r = Convert.ToInt32(Console.ReadLine());


            //for (int i = 1; i <= r; i++) //outer loop for rows
            //{

            //    for (int j = 1; j <= i; j++) //inner loop stars
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}
            //Console.ReadLine();




            //3]
            //Write a C# program to calculate the sum of all even numbers between 1 and 100 using a while loop

            //int sum = 0;
            //int i = 1;
            //while (i <= 100)
            //{
            //    if (i % 2 == 0)  // checking even 
            //    {
            //        sum = sum + i;  // adds to sum
            //    }
            //    i++;  // increment
            //}

            //Console.WriteLine($"The sum is: {sum}");
            //Console.ReadLine();


            //4]
            // Write a C# program to print a multiplication table from 1 to 5 using nested while loops. 


            //int i= 1; 
            //while (i <= 5)
            //{
            //    int j= 1; 

            //    while (j <= 10)
            //    {                   
            //        Console.Write($"{i} * {j} = {i * j}\n");
            //        j++;
            //    }
            //    Console.WriteLine();
            //    i++;

            //}
            //Console.ReadLine();


            //5]
            //Write a C# program to keep asking the user to enter a positive number and print it. The program
            //should stop when the user enters a negative number.




            //while (true)
            //{

            //    Console.Write("Enter a positive number  ");
            //    int n = Convert.ToInt32(Console.ReadLine());


            //    if (n < 0) //check if number is negative
            //    {
            //        Console.WriteLine("Negative number entered exit");
            //        break;  // Exiting the loop
            //    }

            //    Console.WriteLine($"You entered: {n}");//print positive number
            //}


            //Console.ReadLine();


            ////6]
            //Write a C# program to create a basic menu-driven calculator using nested do-while loops. The 
            //calculator should continue to ask the user for two numbers and an operation(+, -, *, /) until the
            //user chooses to exit.

            //char cal;

            //do
            //{
            //    double number1, number2;
            //    char operation;

            //    Console.WriteLine("Enter first number:");
            //    num = Convert.ToDouble(Console.ReadLine());




            //7]

            //Write a C# program to print all numbers from 1 to 100. Use the continue statement to skip 
            //numbers that are divisible by 3, and use the break statement to stop the loop if the number
            //exceeds 50.



            //for (int i = 1; i <= 100; i++)
            //{

            //    if (i % 3 == 0)
            //    {
            //        continue; //using to skip numbers div by 3
            //    }
            //    else if (i > 50)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.ReadLine();

            //8]
            //Write a C# program to calculate the sum of all odd numbers between 1 and 100 using a for loop.


            //int sum = 0;
            //for (int i = 1; i <= 100; i++)
            //{

            //    if (i % 2 != 0)
            //    {
            //        sum += i;
            //    }


            //}
            //Console.WriteLine($"The sum of odd numbers is {sum}");
            //Console.ReadLine();

            //9]
            //Write a C# program to calculate the factorial of a given number using a while loop. 

            //Console.WriteLine("enter a number");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int factorial = 1;
            //int i = n;
            //while (i > 1)
            //{
            //    factorial *= i;
            //    i--;
            //}
            //Console.WriteLine($"The factorial of {n} is {factorial}");
            //Console.ReadLine();







            //10]
            //Write a C# program to print a number pyramid using a nested while loop. Example for 5 rows: 
            //1
            //2 2          
            //3 3 3
            //4 4 4 4
            //5 5 5 5 5






            //int rows = 5; // Specify the number of rows for the pyramid
            //int i = 1; // Counter for the current row

            //while (i <= rows)
            //{
            //    int j = 1; // Counter for the current number in the row
            //    while (j <= i)
            //    {
            //        Console.Write(i + " "); // Print the current row number
            //        j++; // Increment the number 
            //    }
            //    Console.WriteLine(); // Move to the next line after finishing the current row
            //    i++; // Increment the row 
            //}
            //Console.ReadLine();





            //13]
            //Write a C# program that accepts a number from the user and calculates the sum of its digits using 
            //a do -while loop.







            //Console.Write("Enter a number: ");
            //int n = int.Parse(Console.ReadLine());

            //int sum = 0; // Variable to hold the sum of digits
            //int originalNumber = n; // Store the original number for display


            //do
            //{
            //    int digit = n % 10; // Get the last digit
            //    sum += digit; // Add the digit to the sum
            //    n /= 10; // Remove the last digit from the number
            //}


            //while (n > 0); // Continue until there are no digits left

            //Console.WriteLine($"The sum of the digits of {originalNumber} is: {sum}");
            //Console.ReadLine();





            //14]
            //Write a C# program that accepts 10 numbers from the user and finds the largest number using a 
            //for loop.






            //int largestNumber = int.MinValue;

            //Console.WriteLine("Enter 10 numbers:");


            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write($"Number {i + 1}: ");

            //    int currentNumber = int.Parse(Console.ReadLine()); // Read the current number


            //    if (currentNumber > largestNumber)
            //    {
            //        largestNumber = currentNumber;
            //    }
            //}

            //Console.WriteLine($"The largest number is: {largestNumber}");
            //Console.ReadLine();





            ////15]
            //Write a C# program to calculate the sum of squares of all numbers from 1 to a user-provided 
            //number using a while loop.




            //Console.Write("Enter a number");
            //int number = int.Parse(Console.ReadLine()); 
            //int sumOfSquares = 0; // Variable to hold the sum of squares
            //int i = 1; // Initialize the counter

           
            //while (i <= number)
            //{
            //    sumOfSquares += i * i; // Add the square of the current number to the sum
            //    i++; // Increment the counter
            //}

            //Console.WriteLine($"The sum of squares from 1 to {number} is: {sumOfSquares}"); 
            //Console.ReadLine();












        }

    }
    
}
