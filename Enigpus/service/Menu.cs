using Enigpus.service.impl;
using Console = System.Console;

namespace Enigpus.service;

public class Menu
{
    private readonly string _split = new string('-', 50);
    private readonly IInventoryService _inventoryService = new InventoryService();

    public void RunMenu()
    {
        while (true)
        {
            Console.WriteLine(_split);
            Console.WriteLine("Enigpus");
            Console.WriteLine(_split);
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Search Book");
            Console.WriteLine("3. Get All Book");
            Console.WriteLine("4. Update Book");
            Console.WriteLine("5. Delete Book");
            Console.WriteLine("0. Exit");
            Console.Write("Input selection: ");
            int selection;
            try
            {
                selection = int.Parse(Console.ReadLine() ?? string.Empty);
            }
            catch
            {
                selection = 0;
            }

            switch (selection)
            {
                case 0: return;
                case 1:
                    AddBook();
                    break;
                case 2:
                    SearchBook();
                    break;
                case 3:
                    GetAllBook();
                    break;
                case 4:
                    UpdateBook();
                    break;
                case 5:
                    DeleteBook();
                    break;
                default:
                    Console.WriteLine("Option invalid");
                    break;
            }
        }
    }

    private void AddBook()
    {
        Console.WriteLine(_split);
        Console.WriteLine("Add Book");
        Console.WriteLine(_split);
        Console.WriteLine("Select Option:");
        Console.WriteLine("1. Add Novel");
        Console.WriteLine("2. Add Magazine");
        int selection;
        try
        {
            selection = int.Parse(Console.ReadLine() ?? string.Empty);
        }
        catch
        {
            selection = 0;
        }

        switch (selection)
        {
            case 1:
                AddBookMenu(selection);
                break;
            case 2:
                AddBookMenu(selection);
                break;
            default:
                Console.WriteLine("Option invalid");
                break;
        }
    }

    private void AddBookMenu(int type)
    {
        Console.Write("Input Title: ");
        var title = Console.ReadLine() ?? null;
        Console.Write("Input Publisher: ");
        var publisher = Console.ReadLine() ?? null;
        Console.Write("Input Year: ");
        int year;
        try
        {
            year = int.Parse(Console.ReadLine() ?? string.Empty);
        }
        catch
        {
            Console.WriteLine("Invalid Year Input");
            return;
        }

        switch (type)
        {
            case 1:
            {
                Console.Write("Input Author");
                var author = Console.ReadLine();
                var novel = new Novel();
                if (title is not null) novel.Title = title;
                if (publisher is not null) novel.Publisher = publisher;
                if (year is not 0) novel.Year = year;
                if (author is not null) novel.Author = author;
                _inventoryService.AddBook(novel);
                Console.WriteLine("New Novel Added");
            }
                break;
            case 2:
            {
                var magazine = new Magazine();
                if (title is not null) magazine.Title = title;
                if (publisher is not null) magazine.Publisher = publisher;
                if (year is not 0) magazine.Year = year;
                _inventoryService.AddBook(magazine);
                Console.WriteLine("New Magazine Added");
            }
                break;
        }
    }

    private void SearchBook()
    {
        Console.WriteLine(_split);
        Console.WriteLine("Search Book");
        Console.WriteLine(_split);
        Console.Write("Input the Book Title: ");
        var title = Console.ReadLine();
        if (title is null) return;
        var book = _inventoryService.SearchBook(title);
        if (book is null) return;
        Console.WriteLine(book.ToString());
    }

    private void GetAllBook()
    {
        Console.WriteLine(_split);
        Console.WriteLine("Get All Book");
        Console.WriteLine(_split);
        var books = _inventoryService.GetAllBook();
        foreach (var book in books)
        {
            Console.WriteLine(book.ToString());
        }
    }

    private void UpdateBook()
    {
        Console.WriteLine(_split);
        Console.WriteLine("Update Book");
        Console.WriteLine(_split);
        Console.WriteLine("Select Option:");
        Console.WriteLine("1. Update Novel");
        Console.WriteLine("2. Update Magazine");
        int selection;
        try
        {
            selection = int.Parse(Console.ReadLine() ?? string.Empty);
        }
        catch
        {
            selection = 0;
        }

        switch (selection)
        {
            case 1:
                UpdateBookMenu(selection);
                break;
            case 2:
                UpdateBookMenu(selection);
                break;
            default:
                Console.WriteLine("Option invalid");
                break;
        }
    }

    private void UpdateBookMenu(int type)
    {
        Console.Write("Search Book Title: ");
        var search = Console.ReadLine();
        if (search is null) return;
        var book = _inventoryService.GetBookById(search);
        if (book is null) return;
        Console.Write("Input Title: ");
        var title = Console.ReadLine();
        Console.Write("Input Publisher: ");
        var publisher = Console.ReadLine();
        Console.Write("Input Year: ");
        int year;
        try
        {
            year = int.Parse(Console.ReadLine() ?? string.Empty);
        }
        catch
        {
            Console.WriteLine("Invalid Year Input");
            return;
        }

        switch (type)
        {
            case 1:
            {
                Console.Write("Input Author");
                var author = Console.ReadLine();
                var novel = new Novel { Code = book.Code };
                if (title is not null) novel.Title = title;
                if (publisher is not null) novel.Publisher = publisher;
                if (year is not 0) novel.Year = year;
                if (author is not null) novel.Author = author;
                var updateBook = _inventoryService.UpdateBook(novel);
                Console.WriteLine(_split);
                Console.WriteLine(updateBook.ToString());
            }
                break;
            case 2:
            {
                var magazine = new Magazine { Code = book.Code };
                if (title is not null) magazine.Title = title;
                if (publisher is not null) magazine.Publisher = publisher;
                if (year is not 0) magazine.Year = year;
                var updateBook = _inventoryService.UpdateBook(magazine);
                Console.WriteLine(_split);
                Console.WriteLine(updateBook.ToString());
            }
                break;
        }
    }

    private void DeleteBook()
    {
        Console.WriteLine(_split);
        Console.WriteLine("Delete Book");
        Console.WriteLine(_split);
        Console.Write("Search Book Title: ");
        var search = Console.ReadLine();
        if (search is null) return;
        var book = _inventoryService.GetBookById(search);
        if (book?.Code != null) _inventoryService.DeleteBook(book.Code);
    }
}