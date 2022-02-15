Console.Write("Input the 1st num: ");
int num = Convert.ToInt32(Console.ReadLine()); // First num, the main num. Will be used in future.

Console.Write("Input the 2st num: ");
int another_num = Convert.ToInt32(Console.ReadLine()); // Second num, just for math operations.

Console.WriteLine($"Addition: {num} + {another_num} = {num + another_num}");
Console.WriteLine($"Subtraction: {num} - {another_num} = {num - another_num}");
Console.WriteLine($"Multiplication: {num} * {another_num} = {num * another_num}");
Console.WriteLine($"Division: {num} / {another_num} = {num / another_num}");
Console.WriteLine($"Mod: {num} % {another_num} = {num % another_num}");


int[] array = new int[num];

Console.WriteLine("Array: ");
for (int i = 0; i < num; i++)
{
    array[i] = new Random().Next(num * num); 
    Console.Write($"{array[i]} ");
}
