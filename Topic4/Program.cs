using System;

namespace Topic4
{
    // Тема 4. Обработка исключений. Типы исключений
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("   Тема 4. Обработка исключений. Типы исключений");
            Console.WriteLine();


            // ВАРИАНТ 1: Базовый try-catch (DivideByZeroException)


            try
            {
                int a = 10;
                int b = 0;
                int result = a / b;
                Console.WriteLine($"Результат: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Поймано исключение: {ex.Message}");
            }
        }
    }
}


            // ВАРИАНТ 2: Множественные catch (разные типы исключений)

            //try
            //{
            //    int[] numbers = { 1, 2, 3 };
            //    Console.WriteLine(numbers[5]);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine($"Поймано IndexOutOfRangeException: {ex.Message}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Поймано другое исключение: {ex.Message}");
            //}



            // ВАРИАНТ 3: Фильтры исключений (when)

            //try
            //{
            //    string input = "";
            //    int number = int.Parse(input);
            //    Console.WriteLine($"Число: {number}");
            //}
            //catch (FormatException ex) when (ex.Message.Contains("empty") || ex.Message.Contains("пуст"))
            //{
            //    Console.WriteLine("Сработал фильтр: строка пустая.");
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine($"Обычный FormatException: {ex.Message}");
            //}



            // ВАРИАНТ 4: Блок finally (выполняется всегда)

            //try
            //{
            //    Console.WriteLine("Внутри try: выполняем код...");
            //    throw new InvalidOperationException("Тестовая ошибка");
            //}
            //catch (InvalidOperationException ex)
            //{
            //    Console.WriteLine($"Внутри catch: {ex.Message}");
            //}
            //finally
            //{
            //    Console.WriteLine("Внутри finally: ресурсы освобождены.");
            //}



            // ВАРИАНТ 5: Свойства Message и TargetSite

            //try
            //{
            //    object obj = null;
            //    obj.ToString();
            //}
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine($"Message: {ex.Message}");
            //    Console.WriteLine($"TargetSite: {ex.TargetSite}");
            //}


            // ВАРИАНТ 6: Вложенные try-catch (исключение внутри исключения)
            //try
            //{
            //    try
            //    {
            //        int[] arr = new int[2];
            //        arr[5] = 10; // IndexOutOfRangeException
            //    }
            //    catch (IndexOutOfRangeException ex)
            //    {
            //        Console.WriteLine($"Внутренний catch: {ex.Message}");
            //        throw new Exception("Ошибка проброшена во внешний блок", ex);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Внешний catch: {ex.Message}");
            //    Console.WriteLine($"Внутреннее исключение: {ex.InnerException?.Message}");
            //}



            // ВАРИАНТ 7: Пользовательское исключение (свой класс)

            //try
            //{
            //    throw new MyCustomException("Это моё собственное исключение!");
            //}
            //catch (MyCustomException ex)
            //{
            //    Console.WriteLine($"Поймано пользовательское исключение: {ex.Message}");
            //}



            // ВАРИАНТ 8: Использование блока try-catch в методе

            //    try
            //    {
            //        int result = SafeDivide(10, 0);
            //        Console.WriteLine($"Результат: {result}");
            //    }
            //    catch (DivideByZeroException ex)
            //    {
            //        Console.WriteLine($"Ошибка в методе: {ex.Message}");
            //    }


            //    Console.WriteLine();
            //    Console.WriteLine("   Программа завершена.");
            //    Console.WriteLine();
            //    Console.ReadLine();
            //}


            // Вспомогательные методы (для Варианта 8)


            //    static int SafeDivide(int a, int b)
            //    {
            //        if (b == 0)
            //            throw new DivideByZeroException("Делить на ноль нельзя!");
            //        return a / b;
            //    }

            //}


            // Класс пользовательского исключения (для Варианта 7)

    //public class MyCustomException : Exception
//        {
//            public MyCustomException(string message) : base(message) { }
//        }
//    }
//}
 
