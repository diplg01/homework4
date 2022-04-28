// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число А = ");
string number = Console.ReadLine();

int Sum_numb(string numb)
 {
    int sum = 0;
    int count = numb.Length;
    int temp = Convert.ToInt32(numb);
    for (int i = 0; i < count; i++)
    {
    sum = sum + temp % 10;
    temp = temp / 10; ;
    }
    return sum;
}
Console.WriteLine($"Сумма цифр числа {number} равна {Sum_numb(number)}");
Console.WriteLine("Press any key to continue . . . ");
Console.ReadKey(true);
