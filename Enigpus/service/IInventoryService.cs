namespace Enigpus.service;

public interface IInventoryService
{
    public void AddBook(string title, string publisher, int year, string? author);
    public Book SearchBook(string title);
    public List<Book> GetAllBook();
    public Book UpdateBook(string code);
    public void DeleteBook(string code);
}