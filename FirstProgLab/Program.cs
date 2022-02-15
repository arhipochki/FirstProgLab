Console.Write("Input the 1st num: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the 2st num: ");
int another_num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Addition: {num} + {another_num} = {num + another_num}");
Console.WriteLine($"Subtraction: {num} - {another_num} = {num - another_num}");
Console.WriteLine($"Multiplication: {num} * {another_num} = {num * another_num}");
Console.WriteLine($"Division: {num} / {another_num} = {num / another_num}");
Console.WriteLine($"Mod: {num} % {another_num} = {num % another_num}");


int[] array = new int[num];

Console.WriteLine("Array: ");
for (int i = 0; i < num; i++)
{
    array[i] = new Random().Next(num * another_num);
    Console.Write($"{array[i]} ");
}


