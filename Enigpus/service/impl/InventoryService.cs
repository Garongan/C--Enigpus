using System.Globalization;

namespace Enigpus.service.impl;

public class InventoryService : service.IInventoryService
{
    private List<Book> _books = [];

    public void AddBook(Book book)
    {
        book.Code = new string($"{DateTime.Now.Millisecond}-{DateTime.Now.Microsecond}-{DateTime.Now.Nanosecond}");
        Console.WriteLine(book.Code);
        _books.Add(book);
    }

    public List<Book> SearchBook(string title)
    {
        return (from book in _books
                where title != null && book.GetTitle().Contains(title)
                group book by book.GetType()
            ).SelectMany(g => g).ToList();
    }

    public Book? GetBookById(string code)
    {
        return (from b in _books
            where b.Code.Equals(code)
            select b).FirstOrDefault(null as Book);
    }

    public List<Book> GetAllBook()
    {
        return (from book in _books
                orderby book.Code
                group book by book.GetType()
            ).SelectMany(g => g).ToList();
        ;
    }

    public void UpdateBook(Book book)
    {
        if (book.Code != null) DeleteBook(book.Code);
        _books.Add(book);
    }

    public void DeleteBook(string code)
    {
        _books = (from book in _books
                where !book.Code.Equals(code)
                select book
            ).ToList();
    }
}