using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());

            int result = DivideByTwo(num);
            Console.WriteLine("Результат деления: " + result);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Ошибка: Введено некорректное число. " + ex.Message);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Ошибка: Деление на ноль. " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Произошла неожиданная ошибка. " + ex.Message);
        }
    }

    static int DivideByTwo(int num)
    {
        if (num == 0)
        {
            throw new DivideByZeroException("Попытка деления на ноль.");
        }
        return num / 2;
    }
}
