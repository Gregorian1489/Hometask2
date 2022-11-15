int number = new Random().Next(100, 1000);
Console.WriteLine($"Наше случайное число = {number}");
int a = number/10;
int b = a%10;
Console.WriteLine($"Второе число = {b}");
