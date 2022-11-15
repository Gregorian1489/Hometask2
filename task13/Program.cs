Console.WriteLine($"Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = number;
int count = 0;
int count2 = 0;
int x = 0;

while (number/10 > 0)
{
    number = number/10;
    count++;
}
while (count2 < count - 2)
    {
    number2 = number2/10;
    count2++;    
    }
    if (count<2)
    {
    Console.WriteLine("Третьей цифры нет");     
    }
    else if (count>=2)
    {
    x = number2%10;
    Console.WriteLine($"Третья цифра = {x}");
    }
    // Для отрицательных чисел прописывать не стал, т.к. логика понятна