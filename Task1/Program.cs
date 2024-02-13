// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("Напишите число для проверки карности 7 и 23 ");
int number = Convert.ToInt32(Console.ReadLine());
     
            if (number == 0) {
                Console.WriteLine("Вы ввели 0 - это недопустимое значение ");
            }
            else if (number % 7 == 0 && number % 23 ==0) {
                Console.WriteLine($"Число {number} является кратным 7 и 23");
            }
            else {
                Console.WriteLine($"Число {number} не  является кратным 7 и 23");
            }
            