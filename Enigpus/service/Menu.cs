using Enigpus.service.impl;
using Console = System.Console;

namespace Enigpus.service;

public class Menu
{
    private readonly string _split = new string('-', 50);
    private IInventoryService _inventoryService = new InventoryService();

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
            var selection = int.Parse(Console.ReadLine() ?? "");
            switch (selection)
            {
                case 0: return;
                case 1:
                    AddBook();
                    break;
                case 2:
                    SearchBook();
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
        var selection = int.Parse(Console.ReadLine() ?? "");
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
        var title = Console.ReadLine() ?? "";
        Console.Write("Input Publisher: ");
        var publisher = Console.ReadLine() ?? "";
        Console.Write("Input Year: ");
        var year = int.Parse(Console.ReadLine() ?? "");
        switch (type)
        {
            case 1:
            {
                Console.Write("Input Author");
                var author = Console.ReadLine();
                _inventoryService.AddBook(title, publisher, year, author);
            }
                break;
            case 2:
            {
                _inventoryService.AddBook(title, publisher, year, null);
            }
                break;
        }
    }

    private void SearchBook()
    {
        Console.WriteLine(_split);
        Console.WriteLine("SearchBook");
        Console.WriteLine(_split);
        Console.Write("Input the Book Title: ");
        var title = Console.ReadLine();
        if (title is null) return;
        var book = _inventoryService.SearchBook(title);
        Console.WriteLine(book.ToString());
    }
}