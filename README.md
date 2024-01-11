# Guided Assignment - Introduction to Recursion in C#

## Introduction
This assignment will introduce you to recursion in C#, a fundamental concept in computer science and programming. Recursion occurs when a function calls itself directly or indirectly, and it's a powerful tool for solving problems that can be divided into simpler, similar subproblems. We'll explore the basics of recursive functions, including base cases, recursive cases, and practical examples.

---

## Detailed Requirements

#### Project Setup (20 Points)
- Create a new console application in your IDE (e.g., Visual Studio).
- Name the project `GA_Recursion_YourName`, replacing "YourName" with your actual name.
- Ensure the project is correctly set up with necessary default files (e.g., `Program.cs`).

#### Basic Recursive Function (15 Points)
- Implement a basic recursive function (e.g., calculating factorial).
- Explain the recursive logic in comments, including the base case and the recursive case.

#### Recursive vs Iterative Solutions (15 Points)
- Implement an iterative version (using loops) of the same function.
- Compare recursion and iteration in terms of readability and performance.

#### Understanding Base Cases (15 Points)
- Explain the importance of base cases in recursion to prevent infinite loops.
- Demonstrate a base case in your recursive function with comments.

#### Implementing a More Complex Recursive Function (15 Points)
- Create a more complex recursive function (e.g., Fibonacci sequence, binary search).
- Explain the recursive logic and its execution flow with comments.

#### Handling Edge Cases and Errors (10 Points)
- Implement checks for edge cases and error conditions in your recursive functions (e.g., negative inputs for factorial).
- Explain the importance of handling these cases in comments.

#### Recursive Function Testing and Output (10 Points)
- In the `Main` method, test your recursive functions with various inputs.
- Include tests that demonstrate base cases, recursive cases, and edge cases.
- Ensure the output in the console is accurate and as expected.

#### Submission (5 Points)
- Successfully upload the complete project to GitHub.
- Ensure the repository is public and contains all necessary files.
- Provide the correct GitHub repository link in your Canvas submission.

#### Total (100 Points)
- Each section is mandatory.
- Points are awarded based on fulfilling each detailed requirement accurately.

Make sure to follow each of these requirements closely to ensure you meet all the criteria outlined in the rubric for your assignment.

---

### Starting Code
```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exploring Recursion in C#");
        // Test your recursive functions here
    }
}
```

We'll focus on adding recursive functions to demonstrate the concepts.

---

## Create a Basic Recursive Function

- Implement a function to calculate the factorial of a number using recursion.

```csharp
static int Factorial(int n)
{
    // Base case
    if (n == 0)
        return 1;
    // Recursive case
    else
        return n * Factorial(n - 1);
}
```

**Run your code**  
- Test with a positive integer to see the factorial calculation.

---

## Compare Recursive and Iterative Solutions

- Implement an iterative version of the factorial function using a loop.

```csharp
static int IterativeFactorial(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
        result *= i;
    return result;
}
```

---

## Implementing a More Complex Recursive Function

- Create a function for the Fibonacci sequence using recursion.

```csharp
static int Fibonacci(int n)
{
    // Base cases
    if (n == 0) return 0;
    if (n == 1) return 1;
    // Recursive case
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}
```

---

## Handling Edge Cases and Errors

- Add checks for invalid input and explain their necessity.

```csharp
static int SafeFactorial(int n)
{
    if (n < 0)
        throw new ArgumentException("n must be non-negative");
    return Factorial(n);
}
```

---

## Testing Recursive Functions

- Test both basic and complex recursive functions in the `Main` method.

```csharp
static void Main(string[] args)
{
    Console.WriteLine(Factorial(5)); // Testing basic recursion
    Console.WriteLine(Fibonacci(10)); // Testing complex recursion
    // Add more tests as needed
}
```

---

## Rubric

| Criteria | Description | Points |
|----------|-------------|--------|
| **Project Setup** | Correct setup of the console application. | 20 |
| **Basic Recursive Function** | Implementation and explanation of a basic recursive function. | 15 |
| **Recursive vs Iterative Solutions** | Comparison of recursive and iterative solutions. | 15 |
| **Understanding Base Cases** | Correct explanation and implementation of base cases. | 15 |
| **More Complex Recursive Function** | Implementation of a more complex recursive function. | 15 |
| **Handling Edge Cases and Errors** | Proper handling and explanation of edge cases and errors. | 10 |
| **Recursive Function Testing and Output** | Effective testing and accurate output. | 10 |
| **Submission** | Successful GitHub upload and correct submission link. | 5 |
| **Total** |  | 100 |

