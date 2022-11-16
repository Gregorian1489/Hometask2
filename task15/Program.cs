Console.WriteLine("Введите цифру, обозначающую день недели");
int day = Convert.ToInt32(Console.ReadLine());

if ((day>0) && (day<6))
{
     Console.WriteLine("Это рабочий день");
}
else if ((day == 6) || (day == 7))
{
     Console.WriteLine("Это выходной");
}
else 
{
    Console.WriteLine("В неделе только семь дней");
}