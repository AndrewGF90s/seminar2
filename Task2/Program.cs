// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер
//  координатной четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите число X. X не может быть равен 0");

int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число Y. Y не может быть равен 0");

int y = Convert.ToInt32(Console.ReadLine());

int spot =0;

if(x != 0 && y != 0) {
    if (x > 0 && y > 0) {
    spot = 1;
      Console.WriteLine($"координаты находятся в секторе {spot}");
    }
    else if (x > 0 && y < 0) {
        spot = 4;
         Console.WriteLine($"координаты находятся в секторе {spot}"); 
    }
    else if (x < 0 && y > 0) {
        spot = 2;
          Console.WriteLine($"координаты находятся в секторе {spot}");
    }
    else {
        spot = 3;
          Console.WriteLine($"координаты находятся в секторе {spot}");
    }
}
else {
    Console.WriteLine("Вы ввели некорректные значение");
}





