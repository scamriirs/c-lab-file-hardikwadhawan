5. Write a program to demonstrate the use of various arithmetic, unary, logical, bit-wise, assignment and conditional operators.


using System;

class Program

{

static void Main()

{

int a = 10, b = 5;

Console.WriteLine("Arithmetic Operators:");

Console.WriteLine($"a = {a}, b = {b}");

Console.WriteLine($"a + b = {a + b}");

Console.WriteLine($"a - b = {a - b}");

Console.WriteLine($"a * b = {a * b}");

Console.WriteLine($"a / b = {a / b}");

Console.WriteLine($"a % b = {a % b}");


Console.WriteLine("¥nUnary Operators:");

int x = 10;

Console.WriteLine($"++x = {++x}");

Console.WriteLine($"x++ = {x++}");

Console.WriteLine($"--x = {--x}");

Console.WriteLine($"x-- = {x--}");

Console.WriteLine($"!true = {!true}");



bool p = true, q = false;

Console.WriteLine("¥nLogical Operators:");

Console.WriteLine($"p && q = {p && q}");

Console.WriteLine($"p || q = {p || q}");

Console.WriteLine($"!p = {!p}");



Console.WriteLine("¥nBitwise Operators:");

int i = 5, j = 3;

Console.WriteLine($"i & j = {i & j}");

Console.WriteLine($"i | j = {i | j}");

Console.WriteLine($"i ^ j = {i ^ j}");

Console.WriteLine($"~i = {~i}");

Console.WriteLine($"i << 1 = {i << 1}");

Console.WriteLine($"i >> 1 = {i >> 1}");



int result = 0;

Console.WriteLine("¥nAssignment Operators:");

result = a + b;

Console.WriteLine($"result = a + b = {result}");

result += 10;

Console.WriteLine($"result += 10 = {result}");

result -= 5;

Console.WriteLine($"result -= 5 = {result}");

result *= 2;

Console.WriteLine($"result *= 2 = {result}");

result /= 3;

Console.WriteLine($"result /= 3 = {result}");

result %= 4;

Console.WriteLine($"result %= 4 = {result}");



Console.WriteLine("¥nConditional Operator:");

int max = (a > b) ? a : b;

Console.WriteLine($"The maximum of a and b is {max}");

string str = null;

string resultStr = str ?? "Default value";

Console.WriteLine($"¥nNull-coalescing Operator: {resultStr}");


Console.WriteLine("¥nCompound Assignment Operator:");

int z = 20;

z *= 2;

Console.WriteLine($"z *= 2 results in z = {z}");

Console.WriteLine("¥nEnd of Demonstration!");

}

}


