using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal static class Assignment1
    {
        public static void Main(string[] args)
        {
            //Assignment -1 (MS.Net Programming Basics)
          
            //Q1
            Console.WriteLine("The Percentage of the Student is : " + percentage());
            //Q2
            Console.WriteLine("The Area of the Rectangle is  : " + areaofrectangle());
            //Q3
            Console.WriteLine("Total Secs is : " + timeinsec());
            //Q4
            Console.WriteLine("Celsius to Fahrenheit Conversion : " + temperature());
            //Q5
            Console.WriteLine("Total salary is: " + CalculateTotalSalary());
            //Q6
            Console.WriteLine("The sum of the three digit number is: " + SumOfThreeDigitsNumber());
            //Q7
            SwapNumbers();
            //Q8
            SwapNumberswThird();
            //Q9
            Console.WriteLine("The reversed number is: {0}", ReverseThreeDigitNumber());
            //Q10
            Ispositive();
            //Q11
            IsValidLogin();
            //Q12
            captcha();
            //Q13
            CalculateGrade();
            //Q14
            IsEligibleToMarry();
            //Q15
            CalculateTicketPrice(); 
            //Q16
            IsPalindrome();
            //Q17
            PrintPrimeNumbersinRange();
            //Q18
            PrintFibonacciSeries();
            //Q19
            IsArmstrongNumber();
            //Q20
            SumOfDigits();
            //Q21
            SumOfNNumbers();
            //Q22
            FindNumberOfNotes();
            //Q23
            CalculateTravelAmount();
            //Q24
            FindFactorial();

            //Assignment 4– (Use Functions in all programs)

            /Q1
            CalculateRectangleArea();
            //Q2
            CalculateCircleArea();
            //Q3
            FindSumOfSeries();
            //Q4
            FindSumOfOddNumbers();
            //Q5
            FindSumOfPrimeNumbers();
            //Q6
            PrintFibonacciSeriestilln();
            //Q7
            FindSumOfDigits();
            //Q8
            FindReverseNumber();
            //Q9
            IsPalindromeNum();
            //Q10
            IsLeapYear();

            //Assignment 5 – (Recursive Functions) 

            //Q1
            Console.WriteLine("The sum of the factorial series is: {0}", sum(5));
            //Q2
            Console.WriteLine("{0} is an Armstrong number? {1}", 123, isArmstrong(123);



        }
     
        public static bool isArmstrong(int n)
        {
            if (n < 10)
            {
                return n == Math.Pow(n, n);
            }
            else
            {
                int digit = n % 10;
                int remaining = n / 10;
                return isArmstrong(remaining) && Math.Pow(digit, n.ToString().Length) == n;
            }
        }
    
        public static int fact(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * fact(n - 1);
            }
        }

        public static int sum(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return sum(n - 1) + fact(n);
            }
        }
        public static void IsLeapYear()
        {
            // Get the year from the user
            Console.Write("Enter the year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            // Check if the year is divisible by 400
            bool isLeapYear = year % 400 == 0;

            // If the year is not divisible by 400, then check if it is divisible by 4 and not by 100
            if (!isLeapYear)
            {
                isLeapYear = year % 4 == 0 && year % 100 != 0;
            }

            // Print the result
            if (isLeapYear)
            {
                Console.WriteLine("The year is a leap year.");
            }
            else
            {
                Console.WriteLine("The year is not a leap year.");
            }
        }

        public static void IsPalindromeNum()
        {
            // Get the number from the user
            Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Reverse the number
            int reverseNumber = 0;
            int temp = number;
            while (temp > 0)
            {
                reverseNumber = reverseNumber * 10 + temp % 10;
                temp /= 10;
            }

            // Check if the number is equal to its reverse
            bool isPalindrome = number == reverseNumber;

            // Print the result
            if (isPalindrome)
            {
                Console.WriteLine("The number is a palindrome.");
            }
            else
            {
                Console.WriteLine("The number is not a palindrome.");
            }
        }
        public static void FindReverseNumber()
        {
            // Get the number from the user
            Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Initialize the reverse number
            int reverseNumber = 0;

            // Find the reverse of the number
            while (number > 0)
            {
                reverseNumber = reverseNumber * 10 + number % 10;
                number /= 10;
            }

            // Print the reverse of the number
            Console.WriteLine("The reverse of the number is: {0}", reverseNumber);
        }
        public static void FindSumOfDigits()
        {
            // Get the number from the user
            Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Initialize the sum
            int sum = 0;

            // Find the sum of the digits
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            // Print the sum of the digits
            Console.WriteLine("The sum of the digits is: {0}", sum);
        }

        public static void PrintFibonacciSeriestilln()
        {
            // Initialize the first two terms of the Fibonacci series
            int a = 0;
            int b = 1;

            
            int n;
            Console.Write("Enter the number of terms: ");
            n = Convert.ToInt32(Console.ReadLine());
            // Print the first two terms
            Console.WriteLine(" {0} \n {1}", a, b);
            // Iterate to print the remaining terms
            for (int i = 2; i <= n; i++)
            {
                // Calculate the next term
                int c = a + b;

                // Print the next term
                Console.WriteLine(" {0}", c);

                // Update the values of a and b
                a = b;
                b = c;
            }
        }
        public static void FindSumOfPrimeNumbers()
        {
            // Initialize the sum
            int sum = 0;
            int n;
            Console.Write("Enter the number: ");
            n = Convert.ToInt32(Console.ReadLine());

            // Flag to mark the number as prime
            bool isPrime;

            // Iterate over the numbers from 2 to n
            for (int i = 2; i <= n; i++)
            {
                // Initialize the flag as true
                isPrime = true;

                // Check if the number is divisible by any number from 2 to i-1
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                // If the number is prime, add it to the sum
                if (isPrime)
                {
                    sum += i;
                }
            }

            // Print the sum of the prime numbers
            Console.WriteLine("The sum of the prime numbers is: {0}", sum);
        }
        public static void FindSumOfOddNumbers()
        {
            // Initialize the sum
            int sum = 0;
            int n;
            Console.Write("Enter the number: ");
            n = Convert.ToInt32(Console.ReadLine());

            // Add the odd numbers from 1 to n
            for (int i = 1; i <= n; i += 2)
            {
                sum += i;
            }

            // Print the sum of the odd numbers
            Console.WriteLine("The sum of the odd numbers is: {0}", sum);
        }


        public static void FindSumOfSeries()
        {
            // Initialize the sum
            int sum = 0;
            int n;
            Console.Write("Enter the number of terms: ");
            n = Convert.ToInt32(Console.ReadLine());

            // Add the numbers from 1 to n
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            // Print the sum of the series
            Console.WriteLine("The sum of the series is: {0}", sum);
        }
        public static void CalculateCircleArea()
        {
            // Get the radius of the circle
            Console.Write("Enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            // Calculate the area of the circle
            double area = 3.14 * radius * radius;

            // Print the area of the circle
            Console.WriteLine("The area of the circle is: {0:f2}", area);
        }
        public static void CalculateRectangleArea()
        {
            // Get the length and width of the rectangle
            Console.Write("Enter the length of the rectangle: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the width of the rectangle: ");
            int width = Convert.ToInt32(Console.ReadLine());

            // Calculate the area of the rectangle
            int area = length * width;

            // Print the area of the rectangle
            Console.WriteLine("The area of the rectangle is: {0}", area);
        }

        public static void FindFactorial()
        {
            // Get the number from the user
            Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Initialize the factorial
            int factorial = 1;

            // Calculate the factorial
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            // Print the factorial
            Console.WriteLine("The factorial of the number is: {0}", factorial);
        }

        public static void CalculateTravelAmount()
        {
            // Get the age of the traveler
            Console.Write("Enter the age of the traveler: ");
            int age = Convert.ToInt32(Console.ReadLine());

            // Get the discount offered on the ticket
            Console.Write("Enter the discount offered on the ticket: ");
            double discount = Convert.ToDouble(Console.ReadLine());

            // Calculate the base ticket price
            int ticketPrice = 1000;

            // Calculate the discount amount
            double discountAmount = ticketPrice * discount / 100;

            // Calculate the total amount required to travel
            double totalAmount = ticketPrice - discountAmount;

            // Print the total amount required to travel
            Console.WriteLine("The total amount required to travel is: {0}", totalAmount);
        }
        public static void FindNumberOfNotes()
        {
            // Get the amount from the user
            Console.Write("Enter the amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            // Initialize the variables
            int[] notes = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };
            int[] numberOfNotes = new int[9];

            // Find the number of notes of each denomination
            for (int i = 0; i < 9; i++)
            {
                numberOfNotes[i] = amount / notes[i];
                amount %= notes[i];
            }

            // Print the number of notes
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("{0} notes of {1}", numberOfNotes[i], notes[i]);
            }
        }

        public static void SumOfNNumbers()
        {
            // Get the number of numbers from the user
            Console.Write("Enter the number of numbers: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Initialize the sum of numbers
            int sumOfNumbers = 0;

            // Calculate the sum of numbers
            for (int i = 1; i <= n; i++)
            {
                sumOfNumbers += i;
            }

            // Print the sum of numbers
            Console.WriteLine("The sum of n numbers is: {0}", sumOfNumbers);
        }
        public static void SumOfDigits()
        {
            // Get the number from the user
            Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Initialize the sum of digits
            int sumOfDigits = 0;

            // Calculate the sum of digits
            while (number > 0)
            {
                int digit = number % 10;
                sumOfDigits += digit;
                number /= 10;
            }

            // Print the sum of digits
            Console.WriteLine("The sum of digits is: {0}", sumOfDigits);
        }
        public static void IsArmstrongNumber()
        {
            // Get the number from the user
            Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Calculate the sum of the cubes of the digits
            int sumOfCubes = 0;
            int tempNumber = number;
            while (tempNumber > 0)
            {
                int digit = tempNumber % 10;
                sumOfCubes += digit * digit * digit;
                tempNumber /= 10;
            }

            // Check if the number is an Armstrong number
            bool isArmstrongNumber = (number == sumOfCubes);

            // Display the result
            if (isArmstrongNumber)
            {
                Console.WriteLine("The number is an Armstrong number.");
            }
            else
            {
                Console.WriteLine("The number is not an Armstrong number.");
            }
        }

        public static void PrintFibonacciSeries()
        {
            // Initialize the first two terms of the Fibonacci series
            int a = 0;
            int b = 1;

            // Print the first two terms
            Console.WriteLine(a);
            Console.WriteLine(b);

            // Print the remaining terms
            for (int i = 2; i < 10; i++)
            {
                int c = a + b;
                Console.WriteLine(c);

                a = b;
                b = c;
            }
        }
        public static void PrintPrimeNumbersinRange()
        {
            // Get the lower and upper limits of the range
            Console.Write("Enter the lower limit: ");
            int lowerLimit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the upper limit: ");
            int upperLimit = Convert.ToInt32(Console.ReadLine());

            // Print the prime numbers within the range
            for (int i = lowerLimit; i <= upperLimit; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void IsPalindrome()
        {
            // Get the 3 digit number from the user
            Console.Write("Enter the 3 digit number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int temp = number;
            // Reverse the number
            int reversedNumber = 0;
            int digit;
            while (number > 0)
            {
                digit = number % 10;
                reversedNumber = reversedNumber * 10 + digit;
                number = number / 10;
            }

            // Check if the number is a palindrome
            bool isPalindrome = (temp == reversedNumber);

            // Display the result
            if (isPalindrome)
            {
                Console.WriteLine("The number is a palindrome.");
            }
            else
            {
                Console.WriteLine("The number is not a palindrome.");
            }
        }

        public static void CalculateTicketPrice()
        {
            // Get the ages of five people
            int[] ages = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter the age of person {0}: ", i + 1);
                ages[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Get the per person ticket amount
            double ticketAmount = Convert.ToDouble(Console.ReadLine());

            // Calculate the total ticket price
            double totalTicketPrice = 0.0f;
            for (int i = 0; i < 5; i++)
            {
                if (ages[i] < 12)
                {
                    totalTicketPrice += ticketAmount * 0.7f;
                }
                else if (ages[i] > 59)
                {
                    totalTicketPrice += ticketAmount * 0.5f;
                }
                else
                {
                    totalTicketPrice += ticketAmount;
                }
            }

            // Display the total ticket price
            Console.WriteLine("The total ticket price is: {0}", totalTicketPrice);
        }

        public static void IsEligibleToMarry()
        {
            // Get the male and female ages from the user
            Console.Write("Enter the male age: ");
            int maleAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the female age: ");
            int femaleAge = Convert.ToInt32(Console.ReadLine());

            // Check if the male and female ages are eligible for marriage
            bool isEligibleToMarry = (maleAge >= 21 && femaleAge >= 18);

            // Display the result
            if (isEligibleToMarry)
            {
                Console.WriteLine("The person is eligible to marry.");
            }
            else
            {
                Console.WriteLine("The person is not eligible to marry.");
            }
        }
        public static void CalculateGrade()
        {
            // Get the 5 subject marks from the user
            Console.Write("Enter the first subject mark: ");
            int subject1Mark = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second subject mark: ");
            int subject2Mark = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third subject mark: ");
            int subject3Mark = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the fourth subject mark: ");
            int subject4Mark = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the fifth subject mark: ");
            int subject5Mark = Convert.ToInt32(Console.ReadLine());

            // Calculate the total marks
            int totalMarks = subject1Mark + subject2Mark + subject3Mark + subject4Mark + subject5Mark;

            // Calculate the average marks
            float averageMarks = totalMarks / 5.0f;

            // Determine the grade
            string grade;
            if (averageMarks >= 90)
            {
                grade = "First class";
            }
            else if (averageMarks >= 80)
            {
                grade = "Second class";
            }
            else if (averageMarks >= 70)
            {
                grade = "Third class";
            }
            else if (averageMarks >= 60)
            {
                grade = "Pass";
            }
            else
            {
                grade = "Fail";
            }

            // Display the grade
            Console.WriteLine("Your grade is: {0}", grade);
        }

        public static void captcha()
        {
            // Get the userid and password from the user
            Console.Write("Enter userid: ");
            string userid = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            // Check if the userid and password are correct
            bool isValidLogin = (userid == "admin" && password == "123456");

            if (isValidLogin)
            {

                int randomNumber = 1234;
                Console.WriteLine("Randon Number is : {0} ", randomNumber);

                // Display the random number to the user
                Console.WriteLine("Enter the 4 digit random number: ");
                int enteredNumber = Convert.ToInt32(Console.ReadLine());

                // Check if the user entered the correct number
                if (randomNumber == enteredNumber)
                {
                    Console.WriteLine("Success!");
                }
                else
                {
                    Console.WriteLine("Failed!");
                }
            }
            else
            {
                Console.WriteLine("Invalid login.");
            }
        }
        public static void IsValidLogin()
        {
            // Get the userid and password from the user
            Console.Write("Enter userid: ");
            string userid = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            // Check if the userid and password are correct
            bool isValidLogin = (userid == "admin" && password == "123456");

            if (isValidLogin)
            {
                Console.WriteLine("Login successful.");
            }
            else
            {
                Console.WriteLine("Invalid login.");
            }
        }

        public static void Ispositive()
        {
            // Get the number from the user
            int number = Convert.ToInt32(Console.ReadLine());

            // Check if the number is positive or negative
            if(number >= 0){
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Negative");
            }
        }
        public static int ReverseThreeDigitNumber()
        {
            int number, reverseNumber = 0, remainder;

            // Get the three digit number from the user
            Console.Write("Enter a three digit number: ");
            number = Convert.ToInt32(Console.ReadLine());

            // Reverse the number
            while (number > 0)
            {
                remainder = number % 10;
                reverseNumber = reverseNumber * 10 + remainder;
                number = number / 10;
            }

            return reverseNumber;
        }
        public static void SwapNumberswThird()
        {
            int a = 10, b = 20;

            // Swap the values of a and b without using a third variable
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("a = {0}, b = {1}", a, b);
        }

        public static void SwapNumbers()
        {
            int a = 10, b = 20, temp;

            // Swap the values of a and b using a third variable
            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("a = {0}, b = {1}", a, b);
        }

        public static int SumOfThreeDigitsNumber()
        {
            int n, sum = 0, m;
            Console.Write("Enter a three digit number: ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }
            return sum;
        }
        public static decimal CalculateTotalSalary()
        {
            decimal basicSalary;

            Console.WriteLine("Enter the Basic Salary : ");
            basicSalary = Convert.ToDecimal(Console.ReadLine());

            decimal da = basicSalary * 10 / 100;
            decimal ta = basicSalary * 12 / 100;
            decimal hra = basicSalary * 15 / 100;

            return basicSalary + da + ta + hra;
        }


        public static double temperature()
        {
            double cel;
            Console.WriteLine("Enter the Temperature in Celisus : " );
            cel = Convert.ToDouble(Console.ReadLine());

            double fah;

            fah = (cel * 9)/5 + 32;
            Console.WriteLine(" Temperature in Fahrenheit is : " + fah);

            return fah;
        }
        public static int timeinsec() //Q3
        {
            int hours,mins,sec;

            Console.WriteLine("Enter the Time Hours,min,sec  :");
            hours = Convert.ToInt32(Console.ReadLine());
            mins = Convert.ToInt32(Console.ReadLine());
            sec = Convert.ToInt32(Console.ReadLine());

            int secs;
            secs = (hours * 60 * 60) + (mins * 60) + sec;
            return secs;
        }
        public static double areaofrectangle() //Q2
        {
            double length, breadth;
            Console.WriteLine("Enter Length");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Breadth");
            breadth = Convert.ToDouble(Console.ReadLine());

            double area;

            return area = length * breadth;

        }  
        public static double percentage() //Q1
        {
            int maths, english, physics, chemistry, biology;

            maths = Convert.ToInt32(Console.ReadLine());
            physics = Convert.ToInt32(Console.ReadLine());
            chemistry = Convert.ToInt32(Console.ReadLine());
            english = Convert.ToInt32(Console.ReadLine());
            biology = Convert.ToInt32(Console.ReadLine());

            double percentage;
            percentage = (maths + physics + chemistry + biology + english) / 5;
            
            return percentage;
        } 
    }
}
