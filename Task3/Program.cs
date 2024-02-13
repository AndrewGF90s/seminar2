// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
Console.WriteLine("Введите число от 10 до 99");
int number = Convert.ToInt32(Console.ReadLine());
int check1 = 0;
int check2 = 0;
int maxNumber = 0;
if (number > 10 && number < 99 ) {

    check1 = number / 10;
    check2 = number % 10;
        if (check1 == check2){
            Console.WriteLine("Вы ввели число с одинаковыми цифрами");
        }
        else if (check1 > check2) {
            maxNumber = check1;
            Console.WriteLine($"Большее число будет {maxNumber}");
        }
        else {
            maxNumber = check2;
            Console.WriteLine($"Большее число будет {maxNumber}");
        }
}
else {
    Console.WriteLine("Вы ввели числа не из диапозона от 10 до 99");
}
