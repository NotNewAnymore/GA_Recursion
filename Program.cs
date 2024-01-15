namespace GA_Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Print Numbers from 1 to 10");
                Console.WriteLine("2. Count Down and Up");
                Console.WriteLine("3. Calculate Sum of an Array");
                Console.WriteLine("4. Fibonacci Sequence");
                Console.WriteLine("5. Exit");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("\n1. Printing Numbers from 1 to 10:");
                            PrintNumbersFrom1To10(1);
                            break;

                        case 2:
                            Console.WriteLine("\n2. Counting Down and Up:");
                            CountDownAndUp(5);
                            break;

                        case 3:
                            int[] numbers = { 12, 45, 7, 23, 9 };
                            Console.WriteLine("\n3. Calculating Sum of an Array:");
                            Console.WriteLine("Array elements:");
                            foreach (int num in numbers)
                            {
                                Console.Write(num + " ");
                            }
                            int sum = CalculateSum(numbers, 0);
                            Console.WriteLine($"\nSum of the array elements: {sum}");
                            break;

                        case 4:
                            Console.WriteLine("\n4. Fibonacci Sequence:");
                            Console.WriteLine("Fibonacci sequence of length 10:");
                            for (int i = 0; i < 10; i++)
                            {
                                int result = Fibonacci(i);
                                Console.Write(result + " ");
                            }
                            break;

                        case 5:
                            Console.WriteLine("Exiting the application.");
                            return;

                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid option.");
                }

                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
                Console.Clear();
            }
        }

        // Recursive method to print numbers from 1 to 10
        static void PrintNumbersFrom1To10(int currentNumber)
        {
            if (currentNumber <= 10)
            {
                // Step 1: Check if the current number is less than or equal to 10
                // If true, proceed with the following steps.
                Console.WriteLine($"Printing: {currentNumber}");

                // Step 2: Print the current number
                Console.WriteLine(currentNumber);

                // Step 3: Increase the current number by 1
                int nextNumber = currentNumber + 1;

                // Step 4: Recursively call the function with the next number
                PrintNumbersFrom1To10(nextNumber);

                // Step 5: When the recursion reaches 11, it stops automatically.
            }
        }

        // Recursive method to count down and up
        static void CountDownAndUp(int currentNumber)
        {
            if (currentNumber >= 1)
            {
                // Step 1: Check if the current number is greater than or equal to 1
                // If true, proceed with the following steps.
                Console.WriteLine($"Before Recursive Call: {currentNumber}");

                // Step 2: Print the current number
                // Console.WriteLine($"Before Recursive Call: {currentNumber}");

                // Step 3: Decrease the current number by 1 and make a recursive call
                CountDownAndUp(currentNumber - 1);

                Console.WriteLine($"After Recursive Call: {currentNumber}");

                // Step 4: Print the current number after the recursive call
                // Console.WriteLine($"After Recursive Call: {currentNumber}");
            }
        }

        // Recursive method to calculate the sum of an array
        static int CalculateSum(int[] arr, int index)
        {
            // Base Case: If the index is equal to the array length, return 0 (no elements to add)
            if (index == arr.Length)
            {
                return 0;
            }
            else
            {
                // Recursive Case:
                // Step 1: Add the current element (at the current index) to the sum of the rest of the elements
                int currentElement = arr[index];
                int restOfTheSum = CalculateSum(arr, index + 1);
                Console.WriteLine($"Adding {currentElement} to the sum");
                return currentElement + restOfTheSum;
            }
        }

        // Recursive method to calculate the nth Fibonacci number
        static int Fibonacci(int n)
        {
            // Base Case: If n is 0 or 1, return n
            if (n <= 1)
            {
                return n;
            }
            else
            {
                // Recursive Case:
                // Step 1: Calculate Fibonacci(n - 1) and Fibonacci(n - 2) recursively
                int fibNMinus1 = Fibonacci(n - 1);
                int fibNMinus2 = Fibonacci(n - 2);

                // Step 2: Calculate Fibonacci(n) by summing the results of the previous steps
                int fibN = fibNMinus1 + fibNMinus2;

                // Step 3: Print the calculated Fibonacci number
                Console.WriteLine($"Fibonacci({n}) = {fibN}");

                // Step 4: Return the calculated Fibonacci number
                return fibN;
            }
        }

    } // class


} // namespace
