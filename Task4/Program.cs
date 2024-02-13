// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
Console.WriteLine("Ведите число");
int number = Convert.ToInt32(Console.ReadLine());
int numberModifi = 0;
    while (number > 0) {
                numberModifi = number % 10;
                number = number / 10;
        Console.Write(numberModifi+",");
    }





