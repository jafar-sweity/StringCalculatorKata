// See https://aka.ms/new-console-template for more information
using StringCalculatorKata.Services;

Console.WriteLine("Hello, World!");

var calculator = new StringCalculator();
// Test case 1: empty string
var result = calculator.Add("");
Console.WriteLine(result); // Expected output: 0
// Test case 2: single number
 var result1 = calculator.Add("1");
Console.WriteLine(result1); // Expected output: 1
// Test case 3: two numbers
var result2 = calculator.Add("1,2");
Console.WriteLine(result2); // Expected output: 3