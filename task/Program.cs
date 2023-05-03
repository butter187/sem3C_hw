// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
// System.Console.WriteLine("Введите 5-ти значное число ");
// string number = Console.ReadLine()!;
// if (number.Length == 5)
// {
//     if (number[0]==number[4]&&number[1]==number[3])
//     {
//         Console.WriteLine($"{number} -> да ");
//     }
//     else
//     {
//         Console.WriteLine($"{number} -> нет ");
//     }
// }
// else
// {
//     Console.WriteLine("Введено неверно число");
// }
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[] a = new int[3];
// int[] b = new int[3];

// a[0] = ReadInt("Введите координату х точки а ");
// a[1] = ReadInt("Введите координату y точки а ");
// a[2] = ReadInt("Введите координату z точки а ");
// b[0] = ReadInt("Введите координату х точки b ");
// b[1] = ReadInt("Введите координату y точки b ");
// b[2] = ReadInt("Введите координату z точки b ");

// double res = Math.Round(Math.Sqrt(Math.Pow(a[0]-b[0], 2)+ Math.Pow(a[1]-b[1], 2)+Math.Pow(a[2]-b[2], 2)),2);
// System.Console.WriteLine("Растояние между точками  =" + res);

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = ReadInt("Введите число: ");

for (int i = 1; i <= number; i++)
{
    System.Console.Write(Math.Pow(i, 3) + " ");
}
