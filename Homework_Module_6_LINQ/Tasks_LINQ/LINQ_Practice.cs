using System.Runtime.InteropServices.JavaScript;

namespace Homework_Module_6_LINQ.Tasks_LINQ;

class Item 
{ 
    public string Category; 
    public int Value; 
}

public class LINQ_Practice
{
    public void Run()
    {
        // Дана коллекция List<int> numbers. Написать **одно** выражение где:
        // - Выбрать все чётные числа.
        // - Выбрать все числа больше заданного порога threshold.
        /*
        List<int> numbers = new List<int>() { 10, 1, 9, 4, 2, 6, 6, 6, 7, 18, 0, 4, 7 };

        var result = numbers.Where(n => n % 2 == 0);

        foreach (var item in result)
            Console.Write(item + " | ");

        Console.WriteLine();

        var result2 = numbers.Where(n => n > 6);

        foreach (var item in result2)
            Console.Write(item + " | ");
        */
        // Дана коллекция List<string> words. Написать **одно** выражения где:
        // - Преобразовать каждую строку в верхний регистр.
        // - Потом получить длины всех строк.
        /*
        List<string> words = new List<string>() { "one", "two", "three", "four", "five", "six" };

        var result3 = words.Select(word => word.ToUpper());

        foreach (var item in result3)
            Console.Write(item.Length + " | ");
        */
        // Дана коллекция List<int> numbersWithDuplicates.
        // Получите список уникальных значений, используя только LINQ выражения (не хэшсет)
        /*
        List<int> numbersWithDuplicates = new List<int>() { 10, 18, 9, 4, 2, 6, 6, 6, 7, 18, 0, 4, 7 };

        var result4 = numbersWithDuplicates.Distinct();

        foreach (var item in result4)
            Console.Write(item + " | ");
        */
        // Даны List<string> emails. Написать **одно** выражения где:
        // - Найти первый адрес, который заканчивается на "@gmail.com" 
        // - Перед этим проверить, есть ли вообще такой элемент
        /*
        List<string> emails = new List<string>() { "one@mail.ru", "two@yandex.ru", "three@arcanum.com", "four@gmail.com", "five@gmail.com" };

        var result5 = emails.FirstOrDefault(email => email.Contains("@gmail.com"));

        Console.WriteLine(result5);
        */
        // Даны List<string> names. Написать **одно** выражения где:
        // - Отсортировать по алфавиту
        // - Отсортированное по алфавиту отсортировать по длине строки
        /*
        List<string> names = new List<string>() { "Ben", "Tom", "Michelangelo", "Alex", "John", "Dean" };

        var result6 = names.OrderBy(name => name).OrderBy(name => name.Length);

        foreach (var name in result6)
            Console.Write(name + " | ");
        */
        // //Дана List<decimal> prices. Написать **два** выражения где:
        // - Посчитать общую сумму
        // - Посчитать среднее
        /*
        List<decimal> prices = new List<decimal>() { 10, 18, 9, 4, 2, 6, 6, 6, 7, 18, 0, 4, 7 };

        var sum = prices.Sum();

        var average = prices.Average();

        Console.WriteLine(sum + " | " + average);
        */
        // Дана List<int> sequence. Написать **два** выражения где:
        // - Пропустить первые 5 элементов и взять следующие 10
        // - Взять только первые 3 элемента
        /*
        List<int> sequence = new List<int>() { 10, 18, 9, 4, 21, 6, 6, 39, 4, 2, 66, 7, 18, 70, 4, 76, 39, 42, 29, 36, 7, 18, 70 };

        var skipFiveThenTen = sequence.Skip(5).Take(10);
        
        var takeThreeFirst = sequence.Take(3);
        
        foreach (var x in takeThreeFirst)
            Console.Write(x + " | ");
        */
        //-----------------------------------------------------------------------------------------------
        // Дана коллекция простых объектов:
        // Сгруппировать items по Category и посчитать для каждой группы сумму Value
        // Используйте анонимные типы
        
        //List<Item> items = …;
        //-----------------------------------------------------------------------------------------------
        
        // Есть два списка List<int> a и List<int> b. Написать **два** выражения где:
        // - Получить объединённый список со всеми элементами
        // - Получить объединённый список без дубликатов
        /*
        List<int> a = new List<int>() { 10, 18, 9, 4, 21, 6, 6, 39, 4, 2, 66, 7, 18, 70, 4, 76 };
        List<int> b = new List<int>() { 1, 9, 4, 2, 6, 6, 6, 7, 18 };
        
        var mergedList = a.Concat(b);
        
        var withoutDuplicates = a.Concat(b).Distinct();
        
        foreach (var x in withoutDuplicates)
            Console.Write(x + " | ");
        */
        // Дана коллекция List<List<int>> listOfLists.
        // "Развернуть" её в одну плоскую последовательность IEnumerable<int>.
        
        List<int> a = new List<int>() { 10, 18, 9 };
        List<int> b = new List<int>() { 1, 9, 4 };
        List<int> c = new List<int>() { 1, 9, 4, 2 };
        
        List<List<int>> listOfLists = new List<List<int>>() { a, b, c };

        var result = listOfLists.SelectMany(x => x).ToList();
        
        foreach (var x in result)
            Console.Write(x + " | ");
    }
}