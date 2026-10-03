using System;

namespace DEPI_Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("        DEPI - C# Assignment 1         ");
            Console.WriteLine("========================================");

            // ----------------------------------------------------
            // Question 1: Enter a number then print it
            // ----------------------------------------------------
            Console.WriteLine("\n--- Question 1 ---");
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int userNumber))
            {
                Console.WriteLine($"You entered: {userNumber}");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }

            // ----------------------------------------------------
            // Question 2: Convert non-numeric string to integer
            // ----------------------------------------------------
            Console.WriteLine("\n--- Question 2 ---");
            try
            {
                string invalidText = "123abc";
                int parsedNumber = int.Parse(invalidText);
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Result: Exception Caught ({ex.GetType().Name})");
                Console.WriteLine("Explanation: Cannot parse non-numeric characters. It throws a FormatException at runtime.");
            }

            // ----------------------------------------------------
            // Question 3: Floating-point arithmetic operation
            // ----------------------------------------------------
            Console.WriteLine("\n--- Question 3 ---");
            double num1 = 0.1;
            double num2 = 0.2;
            double floatResult = num1 + num2;
            Console.WriteLine($"0.1 + 0.2 = {floatResult}");
            Console.WriteLine("Explanation: Due to binary floating-point representation, precision issues occur (0.30000000000000004 instead of 0.3).");

            // ----------------------------------------------------
            // Question 4: Extract a substring
            // ----------------------------------------------------
            Console.WriteLine("\n--- Question 4 ---");
            string fullText = "Digital Egypt Pioneers Initiative";
            string subText = fullText.Substring(14, 8); // Extracts "Pioneers"
            Console.WriteLine($"Original Text: {fullText}");
            Console.WriteLine($"Extracted Substring: {subText}");

            // ----------------------------------------------------
            // Question 5: Value Type Assignment
            // ----------------------------------------------------
            Console.WriteLine("\n--- Question 5 ---");
            int val1 = 10;
            int val2 = val1;
            val2 = 50;
            Console.WriteLine($"val1: {val1}, val2: {val2}");
            Console.WriteLine("Explanation: Value types are stored in the Stack. Modifying 'val2' creates a new copy and does NOT affect 'val1'.");

            // ----------------------------------------------------
            // Question 6: Reference Type Assignment
            // ----------------------------------------------------
            Console.WriteLine("\n--- Question 6 ---");
            Person p1 = new Person { Name = "Ahmed" };
            Person p2 = p1;
            p2.Name = "Mina";
            Console.WriteLine($"p1.Name: {p1.Name}, p2.Name: {p2.Name}");
            Console.WriteLine("Explanation: Reference types store pointers to the Heap. Both variables point to the same object, so modifying 'p2' modifies 'p1'.");

            // ----------------------------------------------------
            // Question 7: Combine two strings
            // ----------------------------------------------------
            Console.WriteLine("\n--- Question 7 ---");
            string first = "Hello ";
            string second = "DEPI!";
            string combinedStr = first + second;
            Console.WriteLine($"Combined String: {combinedStr}");

            // ----------------------------------------------------
            // Multiple Choice Questions Answers (Q8 - Q10)
            // ----------------------------------------------------
            /*
             * Question 8:
             * Answer: b) A value 1 will be assigned to d.
             *
             * Question 9:
             * Answer: d) 61
             *
             * Question 10:
             * Answer: d) 77
             */
        }
    }

    // Helper class for Question 6
    class Person
    {
        public string Name { get; set; }
    }
}
