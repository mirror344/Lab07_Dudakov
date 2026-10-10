//Задание 1.1
// string[] days = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };
// for (int i = days.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine($"{i}: {days[i]}");
// }


//Задание 1.2
// double[] temps = { 5.2, 4.5, -1.2, 3.0, 4.3, 2.0, 0.0 };
// foreach (double temp in temps)
// {
//     Console.Write($"{temp} ");
// }

//Задание 2
// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int sum_prices = 0;
// int count = 0;

// foreach (int price in prices)
// {
//     sum_prices += price;
//     if (price > 100)
//     {
//         count += 1;
//     }
// }

// Console.WriteLine($"Сумма: {sum_prices}, средняя цена: {(double)sum_prices / prices.Length}, количество дороже 100: {count}");

//Задание 3
// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int min = prices[0];
// int max = prices[0];
// int index = 0;
// for (int i = 1; i < prices.Length; i++)
// {
//     if (prices[i] < min)
//     {
//         min = prices[i];
//     }

//     if (prices[i] > max)
//     {
//         max = prices[i];
//         index = i;
//     }
// }

// Console.WriteLine($"Минимальная цена: {min}, индекс самого дорогого товара: {index}");

//Задание 4
// int[] balance = { 100, -50, 20, -5, 0, 75 };

// for (int i = 0; i < balance.Length; i++)
// {
//     if (balance[i] < 0)
//     {
//         balance[i] = 0;
//     }
//     Console.Write($"{balance[i]} ");
// }

//Задание 5
// int[] num = new int[5];
// int count = 0;
// for (int i = 0; i < num.Length; i++)
// {
//     Console.Write($"Введите {i} элемент массива: ");
//     num[i] = int.Parse(Console.ReadLine());
// }

// for (int i = num.Length - 1; i >= 0; i--)
// {
//     Console.Write($"{num[i]} ");
//     if (num[i] % 2 == 0)
//     {
//         count += 1;
//     }
// }
// Console.WriteLine($"Количество четных: {count}");

//Задание 6
// string[] names = { "Анна", "Игорь", "Мария", "Олег", "Ольга" };
// string input = Console.ReadLine();
// int index = -1;
// for (int i = 0; i < names.Length; i++)
// {
//     if (input == names[i])
//     {
//         index = i;
//     }
// }
// if (index >= 0)
// {
//     Console.WriteLine($"Имя {names[index]} находится на {index} позиции");
// }

//Журнал оценок
using System.ComponentModel.DataAnnotations;

int[] grades = new int[8];
for (int i = 0; i < grades.Length; i++)
{
    Console.Write($"Введите {i + 1} оценку (2-5): ");
    grades[i] = int.Parse(Console.ReadLine());
}

int sum = 0;
int min = grades[0];
int max = grades[0];
int count5 = 0;
int count2 = 0;

for (int i = 0; i < grades.Length; i++)
{
    sum += grades[i];
    if (grades[i] < min)
    {
        min = grades[i];
    }
    if (grades[i] > max)
    {
        max = grades[i];
    }
    if (grades[i] == 2)
    {
        count2 += 1;
    }
    if (grades[i] == 5)
    {
        count5 += 1;
    }
    Console.Write($"{grades[i]} ");
}


Console.WriteLine($"Средняя оценка: {(double)sum / grades.Length}");
Console.WriteLine($"Наибольшая оценка: {max}, наименьшая оценка: {min}");
Console.WriteLine($"Количество двоек: {count2}, количество пятерок: {count5}");
if ((double)sum / grades.Length >= 4.5)
{
    Console.WriteLine("Отличник");
}
else if ((double)sum / grades.Length >= 3.5)
{
    Console.WriteLine("Хорошист");
}
else
{
    Console.WriteLine("Есть над чем поработать");
}

//Дополнительное задание
// int[] arr = { 1, 2, 3, 4, 5, 6 };
// int x = 0;
// for (int i = 0; i < arr.Length / 2; i++)
// {
//     x = arr[i];
//     arr[i] = arr[arr.Length - 1 - i];
//     arr[arr.Length - 1 - i] = x;
// }
// foreach (int i in arr)
// {
//     Console.Write($"{i} ");
// }