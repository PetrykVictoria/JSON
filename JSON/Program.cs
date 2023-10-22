using System;
using System.IO;
using Newtonsoft.Json;

public class PublishingHouse
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Adress { get; set; }
}

public class BookData
{
    public int PublishingHouseId { get; set; }

    public string Title { get; set; }

    public PublishingHouse PublishingHouse { get; set; }
}

public class Program
{
    public static void Main()
    {
        // Зчитати JSON-рядок з файлу (замініть шлях на відповідний)
        string json = File.ReadAllText("C:\\Users\\Викуся\\source\\repos\\JSON\\JSON\\jsconfig1.json");

        // Десеріалізувати JSON-рядок у масив об'єктів BookData
        BookData[] books = JsonConvert.DeserializeObject<BookData[]>(json);

        // Вивести дані на консоль
        foreach (var book in books)
        {
            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"Publishing House: {book.PublishingHouse.Name}");
            Console.WriteLine($"Adress: {book.PublishingHouse.Adress}");
            Console.WriteLine();
        }
    }
}
