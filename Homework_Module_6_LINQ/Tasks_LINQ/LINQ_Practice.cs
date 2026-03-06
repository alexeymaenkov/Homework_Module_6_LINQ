namespace Homework_Module_6_LINQ.Tasks_LINQ;

public class LINQ_Practice
{
    public void Run()
    {
        // Дана коллекция List<int> numbers. Написать **одно** выражение где:
        // - Выбрать все чётные числа.
        // - Выбрать все числа больше заданного порога threshold.

        List<int> numbers = new List<int>() { 10, 1, 9, 4, 2, 6, 6, 6, 7, 18, 0, 4, 7 };

        var result = numbers.Where(n => n % 2 == 0);

        foreach (var item in result)
            Console.Write(item + " | ");

        Console.WriteLine();

        var result2 = numbers.Where(n => n > 6);
        
        foreach (var item in result2)
            Console.Write(item + " | ");
        
        // Дана коллекция List<string> words. Написать **одно** выражения где:
        // - Преобразовать каждую строку в верхний регистр.
        // - Потом получить длины всех строк.
        
        


    }
}