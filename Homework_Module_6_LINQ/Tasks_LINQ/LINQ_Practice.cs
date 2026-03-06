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

        List<int> numbers = new List<int>() { 10, 1, 9, 4, 2, 6, 6, 6, 7, 18, 0, 4, 7 };

        int threshold = 6;

        var evenNumbers = numbers.Where(n => n % 2 == 0).Where(n => n > threshold);

        foreach (var item in evenNumbers)
            Console.Write(item + " | ");

        // Дана коллекция List<string> words. Написать **одно** выражения где:
        // - Преобразовать каждую строку в верхний регистр.
        // - Потом получить длины всех строк.

        List<string> words = new List<string>() { "one", "two", "three", "four", "five", "six" };

        var wordsLength = words.Select(word => word.ToUpper()).Select(word => word.Length);

        foreach (var word in wordsLength)
            Console.Write(word + " | ");

        // Дана коллекция List<int> numbersWithDuplicates.
        // Получите список уникальных значений, используя только LINQ выражения (не хэшсет)

        List<int> numbersWithDuplicates = new List<int>() { 10, 18, 9, 4, 2, 6, 6, 6, 7, 18, 0, 4, 7 };

        var distinctNumbers = numbersWithDuplicates.Distinct();

        foreach (var item in distinctNumbers)
            Console.Write(item + " | ");

        // Даны List<string> emails. Написать **одно** выражения где:
        // - Найти первый адрес, который заканчивается на "@gmail.com" 
        // - Перед этим проверить, есть ли вообще такой элемент

        List<string> emails = new List<string>()
            { "one@mail.ru", "two@yandex.ru", "three@arcanum.com", "four@gmail.com", "five@gmail.com" };

        var gmail = emails.FirstOrDefault(email => email.Contains("@gmail.com"));

        Console.WriteLine(gmail);

        // Даны List<string> names. Написать **одно** выражения где:
        // - Отсортировать по алфавиту
        // - Отсортированное по алфавиту отсортировать по длине строки

        List<string> names = new List<string>() { "Ben", "Tom", "Michelangelo", "Alex", "John", "Dean" };

        var namesLength = names.OrderBy(name => name).ThenBy(name => name.Length);

        foreach (var name in namesLength)
            Console.Write(name + " | ");

        // //Дана List<decimal> prices. Написать **два** выражения где:
        // - Посчитать общую сумму
        // - Посчитать среднее

        List<decimal> prices = new List<decimal>() { 10, 18, 9, 4, 2, 6, 6, 6, 7, 18, 0, 4, 7 };

        var sum = prices.Sum();

        var average = prices.Average();

        Console.WriteLine(sum + " | " + average);

        // Дана List<int> sequence. Написать **два** выражения где:
        // - Пропустить первые 5 элементов и взять следующие 10
        // - Взять только первые 3 элемента

        List<int> sequence = new List<int>()
            { 10, 18, 9, 4, 21, 6, 6, 39, 4, 2, 66, 7, 18, 70, 4, 76, 39, 42, 29, 36, 7, 18, 70 };

        var skipFiveThenTen = sequence.Skip(5).Take(10);

        foreach (var x in skipFiveThenTen)
            Console.Write(x + " | ");

        var takeThreeFirst = sequence.Take(3);

        foreach (var x in takeThreeFirst)
            Console.Write(x + " | ");

        // Дана коллекция простых объектов:
        // Сгруппировать items по Category и посчитать для каждой группы сумму Value
        // Используйте анонимные типы

        List<Item> items = new List<Item>
        {
            new Item { Category = "Food", Value = 10 },
            new Item { Category = "Food", Value = 5 },
            new Item { Category = "Tech", Value = 7 },
            new Item { Category = "Tech", Value = 3 },
            new Item { Category = "Clothes", Value = 8 }
        };

        var groups = items.GroupBy(item => item.Category)
            .Select(g => new { Category = g.Key, Sum = g.Sum(x => x.Value) }).ToList();

        foreach (var x in groups)
            Console.WriteLine(x);

        // Есть два списка List<int> a и List<int> b. Написать **два** выражения где:
        // - Получить объединённый список со всеми элементами
        // - Получить объединённый список без дубликатов

        List<int> a = new List<int>() { 10, 18, 9, 4, 21, 6, 6, 39, 4, 2, 66, 7, 18, 70, 4, 76 };
        List<int> b = new List<int>() { 1, 9, 4, 2, 6, 6, 6, 7, 18 };

        var mergedList = a.Concat(b);

        foreach (var x in mergedList)
            Console.Write(x + " | ");

        var withoutDuplicates = a.Concat(b).Distinct();

        foreach (var x in withoutDuplicates)
            Console.Write(x + " | ");

        // Дана коллекция List<List<int>> listOfLists.
        // "Развернуть" её в одну плоскую последовательность IEnumerable<int>.

        List<int> listA = new List<int>() { 10, 18, 9 };
        List<int> listB = new List<int>() { 1, 9, 4 };
        List<int> listC = new List<int>() { 1, 9, 4, 2 };

        List<List<int>> listOfLists = new List<List<int>>() { listA, listB, listC };

        var series = listOfLists.SelectMany(x => x);

        foreach (var x in series)
            Console.Write(x + " | ");
    }
}