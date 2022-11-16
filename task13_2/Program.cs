Console.WriteLine("Введите число"); //  Вопрос 1 по данному решению: как предусмотреть введение отрицательного числа?
string array = Console.ReadLine();  //  Вопрос 2 : Почему не создается массив string [] array = Console.ReadLine()?

int [] array1 = new int[array.Length];

int count = 0;

while (count<array.Length)
{
    array1[count] = int.Parse(Convert.ToString(array[count]));// Вопрос 3: Почему некорректно работает метод Convert.ToInt32?
    count++;                                                  // Вопрос 4: Можно ли, решая задачу способом преобразования в массив
}                                                             // записать её короче?
if (count<3)                                                  // Заранее спасибо!
{
    Console.WriteLine("Третьего числа нет");
}
else 
{
    Console.WriteLine($"Третье число = {array1[2]}");
}