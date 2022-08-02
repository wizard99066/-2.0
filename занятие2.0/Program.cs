// See https://aka.ms/new-console-template for more information
Console.WriteLine("введите число");
int n = Convert.ToInt32(Console.ReadLine());
if (n == 5 | n == 10)
{
    Console.WriteLine("введенное число равно 5 или 10");
}
else

    Console.WriteLine("неизвестное число");
Console.WriteLine();
//выведем массив, затем проверим массив и все его значения, которые меньше 5 заменим на 0
Console.WriteLine("выведем массив");

int[] mas = new int[7];
int r = mas.Length;
for (int i = 0; i < r; i++)
{
    mas[i] = new Random().Next(0, 9);
    Console.Write(mas[i] + "\t");
}
Console.WriteLine();
Console.WriteLine("заменим значения , которые меньше 5 на 0");
Console.WriteLine();

for (int i = 0; i < r; i++)
{
    if (mas[i] < 5)
    {
        mas[i] = 0;

    }

    Console.Write(mas[i] + "\t");
}
Console.ReadKey();

